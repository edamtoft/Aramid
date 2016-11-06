using Aramid.Html;

namespace Aramid.Html.Tests.SampleComponents
{
  class CtaButton : HtmlComponent
  {
    public CtaButton(string href)
    {
      _href = href;
    }

    readonly string _href;

    public override IHtmlNode Render()
    {
      return new A("btn btn-primary btn-lg", new { href = _href }) { Children };
    }
  }
}
