using Aramid.Html;

namespace Aramid.Html.Tests.SampleComponents
{
  class FormInput : HtmlComponent
  {
    private readonly Field _field;

    public FormInput(Field field)
    {
      _field = field;
    }


    public override IHtmlNode Render()
    {
      switch (_field)
      {
        case Field.Phone:
          return RenderInput("tel");
        case Field.Comments:
          return RenderTextArea();
        case Field.Name:
        default:
          return RenderInput("text");
      }
    }

    private IHtmlNode RenderInput(string type)
    {
      return new Div("form-group")
      {
        new Label(new { @for = _field }) { GetLabel(_field) },
        new Input("form-control", new { type, name = _field, id = _field })
      };
    }

    private IHtmlNode RenderTextArea()
    {
      return new Div("form-group")
      {
        new Label(new { @for = _field }) { GetLabel(_field) },
        new Textarea("form-control", new { name = _field, id = _field })
      };
    }

    private static string GetLabel(Field field)
    {
      switch (field)
      {
        case Field.Comments:
          return "Comments";
        case Field.Name:
          return "Your Name";
        case Field.Phone:
          return "Your Phone Number";
        default:
          return field.ToString();
      }
    }
  }
}
