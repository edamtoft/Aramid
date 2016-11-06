using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aramid.Html
{
  internal interface ISyntaxCompatable : IEnumerable
  {
    void Add(IHtmlNode element);
    void Add(string text);
    void Add(HtmlElement element);
    void Add(HtmlComponent element);
    void Add(IEnumerable<IHtmlNode> elements);
    void Add(Func<IHtmlNode> element);
    void Add(Func<string> text);
    void Add(Func<HtmlElement> element);
    void Add(Func<HtmlComponent> element);
    void Add(Func<IEnumerable<IHtmlNode>> elements);
  }
}
