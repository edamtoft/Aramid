using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aramid.Html.Tests
{
  [TestClass]
  public class HtmlOpsTests
  {
    [TestMethod]
    public void ToHtmlTest()
    {
      var element = new HtmlElement("p") { "Sample" };

      var expected = "<p>Sample</p>";

      Assert.AreEqual(expected, element.ToHtml());
    }
  }
}