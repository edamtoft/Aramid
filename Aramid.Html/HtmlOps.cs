using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aramid.Html
{
  /// <summary>
  /// Extensions for IHtmlElement
  /// </summary>
  public static class HtmlOps
  {
    public static string ToHtml(this IHtmlNode element)
    {
      using (var html = new StringWriter())
      {
        element.Render(html);
        return html.ToString();
      }
    }

    public static void Render(this IHtmlNode element, TextWriter html)
    {
      var visitor = new DefaultHtmlVisitor(html);
      element.Render(visitor);
    }

    public static void Render(this IHtmlNode element, IHtmlVisitor visitor)
    {
      visitor.Visit(element);
    }
  }
}
