using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a single empty HTML tag
  /// </summary>
  public class HtmlVoidElement : IHtmlNode
  {
    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="className">Class Name (or multiple separated by whitespace)</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlVoidElement(string tagName, string className, object props) : this(tagName, new[] { className }, props) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="classes">Class names</param>
    public HtmlVoidElement(string tagName, params string[] classes) : this(tagName, classes, null) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlVoidElement(string tagName, object props) : this(tagName, new string[0], props) { }

    /// <summary>
    /// Declares an HTML element
    /// </summary>
    /// <param name="tagName">Tag name</param>
    /// <param name="classes">Class names</param>
    /// <param name="props">An object who's properties will be mapped to the elements properties. CamelCased names will be transformed to dash-separated.</param>
    public HtmlVoidElement(string tagName, string[] classes, object props = null)
    {
      NodeName = tagName?.ToUpper();
      Classes = new List<string>(classes?.Where(c => c != null).SelectMany(c => c.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
      Props = props?.GetType()
        .GetProperties()
        .ToDictionary(p => HtmlUtils.PropName(p.Name), p => p.GetValue(props))
        ?? new Dictionary<string, object>();
    }

    /// <summary>
    /// Tag Name
    /// </summary>
    public string NodeName { get; }

    /// <summary>
    /// Dictionary of property name (dash-separated) to property value
    /// </summary>
    public readonly IDictionary<string, object> Props;

    /// <summary>
    /// This elements classes
    /// </summary>
    public readonly IList<string> Classes;

    public override string ToString() => this.ToHtml();
  }
}
