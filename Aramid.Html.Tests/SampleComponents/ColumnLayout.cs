using System;
using System.Linq;
using Aramid.Html;

namespace Aramid.Html.Tests.SampleComponents
{
  class ColumnLayout : HtmlComponent
  {
    public override IHtmlNode Render()
    {
      var width = Math.Floor(12 / (double)Children.Count);
      return new Div("row")
      {
        Children.Select(child => new Div($"col-sm-{width}") { child })
      };
    }
  }
}
