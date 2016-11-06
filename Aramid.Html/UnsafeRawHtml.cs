using System;
using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a raw HTML snippet. CAUTION! You must validate all HTML before using this, as it may expose XSS vulnerabilities.
  /// </summary>
  public struct UnsafeRawHtml : IHtmlNode
  {
    public UnsafeRawHtml(string html)
    {
      Html = html ?? string.Empty;
    }

    public readonly string Html;

    public string NodeName => null;

    public override string ToString() => Html;
    public override bool Equals(object obj) => Html.Equals(obj);
    public override int GetHashCode() => Html.GetHashCode();

    public static explicit operator UnsafeRawHtml(string html) => new UnsafeRawHtml(html);
  }
}
