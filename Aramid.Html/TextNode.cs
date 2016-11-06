using System;
using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a HTML text node. Input text will be escaped.
  /// </summary>
  public struct TextNode : IHtmlNode
  {
    public TextNode(string text)
    {
      Value = text ?? string.Empty;
    }

    public readonly string Value;

    public string NodeName => "#text";

    public override string ToString() => Value;
    public override bool Equals(object obj) => Value.Equals(obj);
    public override int GetHashCode() => Value.GetHashCode();


    public static implicit operator TextNode(string text) => new TextNode(text);
  }
}
