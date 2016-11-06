using System.IO;

namespace Aramid.Html
{
  /// <summary>
  /// Represents a block of HTML.
  /// </summary>
  public interface IHtmlNode
  {
    string NodeName { get; }
  }
}
