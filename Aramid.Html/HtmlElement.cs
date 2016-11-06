using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a single HTML tag
  /// </summary>
  public class HtmlElement : IHtmlNode, IEnumerable<IHtmlNode>, ISyntaxCompatable
  {
    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="className">Class Name (or multiple separated by whitespace)</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlElement(string tagName, string className, object props) : this(tagName, new[] { className }, props) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="classes">Class names</param>
    public HtmlElement(string tagName, params string[] classes) : this(tagName, classes, null) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlElement(string tagName, object props) : this(tagName, new string[0], props) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="classes">Class names</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlElement(string tagName, string[] classes, object props = null)
    {
      NodeName = tagName?.ToUpper();
      Classes = new List<string>(classes?.Where(c => c != null).SelectMany(c => c.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
      Children = new List<IHtmlNode>();
      Props = props?.GetType()
        .GetProperties()
        .ToDictionary(p => HtmlUtils.PropName(p.Name), p => p.GetValue(props)) 
        ?? new Dictionary<string, object>();
    }

    /// <summary>
    /// Tag Name, E.G "DIV"
    /// </summary>
    public string NodeName { get; }

    /// <summary>
    /// Dictionary of property name (dash-separated) to property value
    /// </summary>
    public readonly IDictionary<string, object> Props;

    /// <summary>
    /// This element's child elements
    /// </summary>
    public readonly IList<IHtmlNode> Children;

    /// <summary>
    /// This elements classes
    /// </summary>
    public readonly IList<string> Classes;

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
      if (element != null) Children.Add(element);
    }

    public override string ToString() => this.ToHtml();

    public IEnumerator<IHtmlNode> GetEnumerator() => Children.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Children).GetEnumerator();
  }
}
