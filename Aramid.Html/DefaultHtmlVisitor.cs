using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aramid.Html;

namespace Aramid
{
  class DefaultHtmlVisitor : HtmlVisitor
  {
    private readonly TextWriter _html;

    public DefaultHtmlVisitor(TextWriter html)
    {
      _html = html;
    }

    protected override void VisitElement(HtmlElement e)
    {
      _html.Write($"<{e.NodeName.ToLower()}");

      if (e.Classes.Count > 0)
      {
        var className = string.Join(" ", e.Classes.Where(c => c != null));
        _html.Write($" class=\"{className}\"");
      }

      foreach (var prop in e.Props.Where(prop => prop.Value != null))
      {
        _html.Write($" {prop.Key}=\"{HtmlUtils.Attribute(prop.Value)}\"");
      }

      _html.Write(">");
      foreach (var child in e.Children)
      {
        Visit(child);
      }
      _html.Write($"</{e.NodeName.ToLower()}>");
    }

    protected override void VisitElement(HtmlVoidElement e)
    {
      _html.Write($"<{e.NodeName.ToLower()}");

      if (e.Classes.Count > 0)
      {
        var className = string.Join(" ", e.Classes.Where(c => c != null));
        _html.Write($" class=\"{className}\"");
      }

      foreach (var prop in e.Props.Where(prop => prop.Value != null))
      {
        _html.Write($" {prop.Key}=\"{HtmlUtils.Attribute(prop.Value)}\"");
      }

      _html.Write("/>");
    }

    protected override void VisitElement(TextNode e)
    {
      _html.Write(HtmlUtils.Escape(e.Value));
    }

    protected override void VisitElement(Comment e)
    {
      _html.Write($"<!-- {HtmlUtils.Escape(e.Text)} -->");
    }

    protected override void VisitElement(Document e)
    {
      _html.Write("<!DOCTYPE html>");
      foreach (var child in e.Children)
      {
        Visit(child);
      }
    }

    protected override void VisitElement(UnsafeRawHtml e)
    {
      _html.Write(e.Html);
    }

    protected override void VisitElement(HtmlComponent component)
    {
      Visit(component.Render());
    }

    protected override void VisitElement(IHtmlNode node)
    {
      throw new NotSupportedException($"Unsupported node type <{node.GetType().Name}>");
    }
  }
}
