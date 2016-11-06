using System;
using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Represents an HTML comment
  /// </summary>
  public struct Comment : IHtmlNode
  {
    public Comment(string text)
    {
      Text = text ?? string.Empty;
    }

    public readonly string Text;

    public string NodeName => "#comment";

    public override string ToString() => Text;
    public override bool Equals(object obj) => Text.Equals(obj);
    public override int GetHashCode() => Text.GetHashCode();

    public static implicit operator Comment(string text) => new Comment(text);
  }
}
  