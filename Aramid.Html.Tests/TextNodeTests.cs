using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aramid.Html.Tests
{
  [TestClass]
  public class TextNodeTests
  {
    [TestMethod]
    public void TextIsEscaped()
    {
      var element = (TextNode) "<some>html<tags>";

      var expected = "&lt;some&gt;html&lt;tags&gt;";

      Assert.AreEqual(expected, element.ToHtml());
    }
  }
}