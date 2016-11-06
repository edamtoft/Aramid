using Aramid.Html;

namespace Aramid.Html.Tests.SampleComponents
{
  /// <summary>
  /// Represents a basic bootstrap modal with a given id/title
  /// </summary>
  class BootstrapModal : HtmlComponent
  {
    public BootstrapModal(string id, string title)
    {
      _id = id;
      _title = title;
    }

    readonly string _title;
    readonly string _id;

    public override IHtmlNode Render()
    {
      return new Div("modal fade", new { id = _id })
      {
        new Div("modal-dialog")
        {
          new Div("modal-header")
          {
            new Button("close", new { dataDismiss = "modal", ariaLabel = "Close" })
            {
              new Span(new { ariaHidden = true }) { "×" }
            },
            new H4 { _title }
          },
          new Div("modal-body") { Children }
        }
      };
    }
  }
}
