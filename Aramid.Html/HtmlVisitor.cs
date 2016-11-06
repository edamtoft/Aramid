using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aramid.Html;

namespace Aramid.Html
{
  public abstract class HtmlVisitor : IHtmlVisitor
  {
    public void Visit(IHtmlNode element) => VisitElement((dynamic)element);

    protected abstract void VisitElement(HtmlElement e);

    protected abstract void VisitElement(HtmlVoidElement e);

    protected abstract void VisitElement(TextNode e);

    protected abstract void VisitElement(Comment e);

    protected abstract void VisitElement(Document e);

    protected abstract void VisitElement(UnsafeRawHtml e);

    protected abstract void VisitElement(HtmlComponent component);

    protected abstract void VisitElement(IHtmlNode node);
  } 
}
