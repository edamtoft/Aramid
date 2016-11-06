# Aramid
Create Strongly-Typed HTML components in c#

## Why
The various flavors of ASP.NET allow for creating templated HTML through .cshtml partials and files, UserControls, etc, but creating components this way has a pretty high "cost" to modularize a collection of related HTML into a reusable format, and in the end, is mostly just string templates. This project was inspired by how React handles creating reusable components to build up scalable UIs. For example, you could create a FormInput component which would include the markup for labels, inputs, etc, and then create a LoginForm component which combined those smaller components together. Small components build up larger components, which eventually can build up whole pages. This keeps UI code DRY (Don't Repeat Yourself), and makes it easy to build up a library of components which are easy to manage and modify, since you get all the benefits of type-safety. For the previous example, if you wanted to make it so all of your forms across an entire project include a new attribute (I.E. autofill hints)? Just change the component. No more Find-and-replace across HTML files.


## Code
Here's what a simple component would look like (a simple bootstrap modal):

```cs
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
```

To create an instance of the modal, with a header and some text as the content, just call:

```cs
var modal = new BootstrapModal("My Modal","my_modal")
{
  new H1 { "Hello World" },
  "This is a modal"
};
```

And to get the HTML, call

```cs
modal.ToHtml();
```


## Syntax
Aramid attempts to make it as easy as possible to make UI components. Creating an object representation of HTML nodes is not hard, but making a syntax which keeps it type-safe and doesn't suck is the challenge. Html elements and Components use Collection Initializer syntax to define child elements. You can mix and match elements, strings, linq statements to define children, base HTML elements use a anonymous object to define properties, and also have a number of constructor overloads for defining a collection of classNames. etc. Also using bootstrap as an example, we'll create a form component:

```cs
class BootstrapFormControl : HtmlComponent
{
  private readonly string _name;
  private readonly string _label

  public BootstrapFormControl(string name, string label)
  {
    _name = name;
    _label = label;
  }

  public override IHtmlNode Render()
  {
    return new Div("form-group") // <div class="form-group">
    {
      new Label(new { @for = _name }) { _label }, // <label for="fieldName">fieldLabel</label>
      new Input("form-control", new { type, name = _name, id = _name }) // <input class="form-control" name="fieldName", id="fieldName">
    };
  }
}
```

if we want to build up a form from a dictionary of name to label, along with a form header and description we could create another component:

```cs
class BootstrapForm : HtmlComponent
{
  private readonly IDictionary<string,string> _fields;
  private readonly string _header;
  private readonly string _description;

  public BootstrapForm(string header, string description, IDictionary<string,string> fields)
  {
    _header = header;
    _description = description;
    _fields = fields;
  }

  public override IHtmlNode Render()
  {
    return new Form("form-group")
    {
      new H1 { _header }, // Strings are always safely escaped throughout
      new P { _description },
      // IEnumerable of string, html element, or htmlNode is allowed
      from field in _fields 
      select new BootstrapFormControl(field.Key, field.Value)
    };
  }
}
```

Check out the unit test project for more examples.

## Install

Install the Aramid NuGet Package

```
PM> Install-Package Aramid
```

## Hard to Break
Aramid is designed to be as much of a "Pit of Success" as possible, so the things you do the most often will be done right with the least amount of work or understanding of the system as possible. Strings are always HTML encoded, type definitions are designed make sure the compiler keeps your HTML valid, and dangerous things are hard to do. If you want to allow arbitraty HTML (and have sufficiently protected against XSS vulnerabilities, etc), you can use the UnsafeRawHtml elemnent.

## Title
Aramid fibers are a class of synthetic polymer fibers which are more commonly known under the brand name Kevlar. The idea behind this project is you use build up larger UIs from smaller building blocks, like amides building up fibers strands and strands being woven together into a very versatile fabric. 


## Contributing
PRs totally welcome, and feel free to open an issue if you find a bug, or have an idea for a new feature.


## Liscence
This project is MIT licensed. See the LISCENCE file for details.