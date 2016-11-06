using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Adds a !DOCTYPE html tag
  /// </summary>
  public class Document : IHtmlNode, IEnumerable<IHtmlNode>
  {
    public readonly List<IHtmlNode> Children;

    public string NodeName => "#document";

    public Document()
    {
      Children = new List<IHtmlNode>();
    }

    public void Add(IHtmlNode element) => AddChild(element);
    public void Add(string text) => AddChild(new TextNode(text));
    public void Add(HtmlElement element) => AddChild(element);
    public void Add(HtmlComponent element) => AddChild(element);
    public void Add(IEnumerable<IHtmlNode> elements) => Children.AddRange(elements);
    private void AddChild(IHtmlNode element) => Children.Add(element);

    public IEnumerator<IHtmlNode> GetEnumerator() => Children.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Children).GetEnumerator();

  }
}
