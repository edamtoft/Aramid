using System.Linq;
using Aramid.Html;

namespace Aramid.Html.Tests.SampleComponents
{
  class InputForm : HtmlComponent
  {
    private readonly Field[] _fields;

    public InputForm(params Field[] fields)
    {
      _fields = fields;
    }

    public override bool AllowChildren => false;

    public override IHtmlNode Render()
    {
      return new Form
      {
        new ColumnLayout
        {
          _fields.Select(field => new FormInput(field))
        }
      };
    }
  }
}
