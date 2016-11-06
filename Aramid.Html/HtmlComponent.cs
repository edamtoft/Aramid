using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a reusable HTML component
  /// </summary>
  public abstract class HtmlComponent : IHtmlNode, IEnumerable<IHtmlNode>, ISyntaxCompatable
  {
    public HtmlComponent()
    {
      Children = new List<IHtmlNode>();
    }

    /// <summary>
    /// Whether the component should allow child elements. If false, an exception will be thrown when
    /// attempting to add a child.
    /// </summary>
    public virtual bool AllowChildren { get; } = true;

    public string NodeName => $"#component({GetType().Name})";

    /// <summary>
    /// Collection of child elements. This must be referenced in the 
    /// </summary>
    protected readonly IList<IHtmlNode> Children;

    /// <summary>
    /// Returns the component
    /// </summary>
    /// <returns></returns>
    public abstract IHtmlNode Render();

    public override string ToString() => this.ToHtml();

    //
    // Add methods allow for collection initializer syntax to be used
    //

    public void Add(IHtmlNode element) => AddChild(element);
    public void Add(string text) => AddChild(new TextNode(text));
    public void Add(HtmlElement element) => AddChild(element);
    public void Add(HtmlComponent element) => AddChild(element);
    public void Add(IEnumerable<IHtmlNode> elements)
    {
      foreach (var element in elements) AddChild(element);
    }
    public void Add(Func<IHtmlNode> elementDelegate) => AddChild(elementDelegate?.Invoke());
    public void Add(Func<string> textDelegate) => AddChild(new TextNode(textDelegate?.Invoke()));
    public void Add(Func<HtmlElement> elementDelegate) => AddChild(elementDelegate?.Invoke());
    public void Add(Func<HtmlComponent> elementDelegate) => AddChild(elementDelegate?.Invoke());
    public void Add(Func<IEnumerable<IHtmlNode>> elementsDelegate)
    {
      foreach (var element in elementsDelegate?.Invoke()) AddChild(element);
    }


    private void AddChild(IHtmlNode element)
    {
      if (!AllowChildren) throw new InvalidOperationException($"Component <{GetType().Name}> does not support child elements");
      Children.Add(element);
    }

    public IEnumerator<IHtmlNode> GetEnumerator() => Children.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => Children.GetEnumerator();
  }
}
