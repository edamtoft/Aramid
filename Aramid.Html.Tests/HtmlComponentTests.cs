using Aramid.Html.Tests.SampleComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aramid.Html.Tests
{
  [TestClass]
  public class HtmlComponentTests
  {

    [TestMethod]
    public void BootstrapModalTest()
    {
      var modal = new BootstrapModal(id: "testModal", title: "Test Modal")
      {
        new H1 { "I'm a Modal" },
        new P { "Hello World" }
      };

      var expected = 
        "<div class=\"modal fade\" id=\"testModal\">" + 
          "<div class=\"modal-dialog\">" +
            "<div class=\"modal-header\">" +
              "<button class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&#215;</span></button>" + 
              "<h4>Test Modal</h4>" + 
            "</div>" +
            "<div class=\"modal-body\">" +
              "<h1>I&#39;m a Modal</h1>" + 
              "<p>Hello World</p>" +
            "</div>" +
          "</div>" + 
        "</div>";

      Assert.AreEqual(expected, modal.ToHtml());
    }

    [TestMethod]
    public void ButtonTest()
    {
      var button = new CtaButton("/somepage.html") { "Call To Action" };

      var expected = "<a class=\"btn btn-primary btn-lg\" href=\"/somepage.html\">Call To Action</a>";

      Assert.AreEqual(expected, button.ToHtml());
    }

    [TestMethod]
    public void FormTests()
    {
      var form = new InputForm(Field.Name, Field.Phone,  Field.Comments);

      var expected = "<form>"+
        "<div class=\"row\">" +
          "<div class=\"col-sm-4\">" +
            "<div class=\"form-group\">" +
              "<label for=\"Name\">Your Name</label>" +
              "<input class=\"form-control\" type=\"text\" name=\"Name\" id=\"Name\"/>" +
            "</div>" +
          "</div>" +
          "<div class=\"col-sm-4\">" +
            "<div class=\"form-group\">" +
              "<label for=\"Phone\">Your Phone Number</label>" +
              "<input class=\"form-control\" type=\"tel\" name=\"Phone\" id=\"Phone\"/>" +
            "</div>" +
          "</div>" +
          "<div class=\"col-sm-4\">" +
            "<div class=\"form-group\">" +
              "<label for=\"Comments\">Comments</label>" +
              "<textarea class=\"form-control\" name=\"Comments\" id=\"Comments\"></textarea>" +
            "</div>" +
          "</div>" +
        "</div>" +
      "</form>";

      Assert.AreEqual(expected, form.ToHtml());
    }


    [TestMethod]
    public void AllowChildrenTests()
    {
      try
      {
        var form = new InputForm() { "Hello World" };
        Assert.Fail("Children should not be allowed.");
      }
      catch
      {
        // Expected
      }
    }

  }
}