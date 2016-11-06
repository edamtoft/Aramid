using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Aramid.Html.Tests
{
  [TestClass]
  public class HtmlElementTests
  {
    [TestMethod]
    public void BasicHtml()
    {
      var element = new Ul("list-unstyled")
      {
        new Li { "Item 1" },
        new Li { "Item 2" },
      };

      var expected = "<ul class=\"list-unstyled\"><li>Item 1</li><li>Item 2</li></ul>";

      Assert.AreEqual(expected, element.ToHtml());
    }

    [TestMethod]
    public void TextAndComments()
    {
      var element = new P
      {
        (Comment) "Hello World",
        "Hello World"
      };

      var expected = "<p><!-- Hello World -->Hello World</p>";

      Assert.AreEqual(expected, element.ToHtml());
    }

    [TestMethod]
    public void SelfClosingTags()
    {
      var element = new P
      {
        new Br(), //should self close
        new Img(new { src = "/test.png" }), // should self close
        new Span(), //should never self close
      };

      var expected = "<p><br/><img src=\"/test.png\"/><span></span></p>";

      Assert.AreEqual(expected, element.ToHtml());
    }

    [TestMethod]
    public void ElementsAreEnumerable()
    {
      var element = new HtmlElement("div")
      {
        new Span(),
        new P(),
        new Span(),
        new P()
      };

      var spanCount = element.OfType<HtmlElement>().Where(e => e.NodeName == "SPAN").Count();

      Assert.AreEqual(2, spanCount);
    }

    [TestMethod]
    public void ElementsCanBeInitializedWithFunctions()
    {
      var name = "test";
      var element = new HtmlElement("div")
      {
        "The name is: ",
        () => name == "test" ? "test" : "not test"
      };

      var expected = "<div>The name is: test</div>";

      Assert.AreEqual(expected, element.ToHtml());
    }
  }
}