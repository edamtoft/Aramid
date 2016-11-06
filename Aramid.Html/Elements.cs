namespace Aramid.Html
{
  /// <summary>
  /// HTML A Tag
  /// </summary>
  public class A : HtmlElement
  {
    public A(string className, object props) : base("A", new[] { className }, props) { }

    public A(string[] classes, object props) : base("A", classes, props) { }

    public A(params string[] classes) : base("A", classes, null) { }

    public A(object props) : base("A", new string[0], props) { }
  }

  /// <summary>
  /// HTML Abbr Tag
  /// </summary>
  public class Abbr : HtmlElement
  {
    public Abbr(string className, object props) : base("ABBR", new[] { className }, props) { }

    public Abbr(string[] classes, object props) : base("ABBR", classes, props) { }

    public Abbr(params string[] classes) : base("ABBR", classes, null) { }

    public Abbr(object props) : base("ABBR", new string[0], props) { }
  }

  /// <summary>
  /// HTML Address Tag
  /// </summary>
  public class Address : HtmlElement
  {
    public Address(string className, object props) : base("ADDRESS", new[] { className }, props) { }

    public Address(string[] classes, object props) : base("ADDRESS", classes, props) { }

    public Address(params string[] classes) : base("ADDRESS", classes, null) { }

    public Address(object props) : base("ADDRESS", new string[0], props) { }
  }

  /// <summary>
  /// HTML Area Tag
  /// </summary>
  public class Area : HtmlVoidElement
  {
    public Area(string className, object props) : base("AREA", new[] { className }, props) { }

    public Area(string[] classes, object props) : base("AREA", classes, props) { }

    public Area(params string[] classes) : base("AREA", classes, null) { }

    public Area(object props) : base("AREA", new string[0], props) { }
  }

  /// <summary>
  /// HTML Article Tag
  /// </summary>
  public class Article : HtmlElement
  {
    public Article(string className, object props) : base("ARTICLE", new[] { className }, props) { }

    public Article(string[] classes, object props) : base("ARTICLE", classes, props) { }

    public Article(params string[] classes) : base("ARTICLE", classes, null) { }

    public Article(object props) : base("ARTICLE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Aside Tag
  /// </summary>
  public class Aside : HtmlElement
  {
    public Aside(string className, object props) : base("ASIDE", new[] { className }, props) { }

    public Aside(string[] classes, object props) : base("ASIDE", classes, props) { }

    public Aside(params string[] classes) : base("ASIDE", classes, null) { }

    public Aside(object props) : base("ASIDE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Audio Tag
  /// </summary>
  public class Audio : HtmlElement
  {
    public Audio(string className, object props) : base("AUDIO", new[] { className }, props) { }

    public Audio(string[] classes, object props) : base("AUDIO", classes, props) { }

    public Audio(params string[] classes) : base("AUDIO", classes, null) { }

    public Audio(object props) : base("AUDIO", new string[0], props) { }
  }

  /// <summary>
  /// HTML B Tag
  /// </summary>
  public class B : HtmlElement
  {
    public B(string className, object props) : base("B", new[] { className }, props) { }

    public B(string[] classes, object props) : base("B", classes, props) { }

    public B(params string[] classes) : base("B", classes, null) { }

    public B(object props) : base("B", new string[0], props) { }
  }

  /// <summary>
  /// HTML Base Tag
  /// </summary>
  public class Base : HtmlVoidElement
  {
    public Base(string className, object props) : base("BASE", new[] { className }, props) { }

    public Base(string[] classes, object props) : base("BASE", classes, props) { }

    public Base(params string[] classes) : base("BASE", classes, null) { }

    public Base(object props) : base("BASE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Bdi Tag
  /// </summary>
  public class Bdi : HtmlElement
  {
    public Bdi(string className, object props) : base("BDI", new[] { className }, props) { }

    public Bdi(string[] classes, object props) : base("BDI", classes, props) { }

    public Bdi(params string[] classes) : base("BDI", classes, null) { }

    public Bdi(object props) : base("BDI", new string[0], props) { }
  }

  /// <summary>
  /// HTML Bdo Tag
  /// </summary>
  public class Bdo : HtmlElement
  {
    public Bdo(string className, object props) : base("BDO", new[] { className }, props) { }

    public Bdo(string[] classes, object props) : base("BDO", classes, props) { }

    public Bdo(params string[] classes) : base("BDO", classes, null) { }

    public Bdo(object props) : base("BDO", new string[0], props) { }
  }

  /// <summary>
  /// HTML Blockquote Tag
  /// </summary>
  public class Blockquote : HtmlElement
  {
    public Blockquote(string className, object props) : base("BLOCKQUOTE", new[] { className }, props) { }

    public Blockquote(string[] classes, object props) : base("BLOCKQUOTE", classes, props) { }

    public Blockquote(params string[] classes) : base("BLOCKQUOTE", classes, null) { }

    public Blockquote(object props) : base("BLOCKQUOTE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Body Tag
  /// </summary>
  public class Body : HtmlElement
  {
    public Body(string className, object props) : base("BODY", new[] { className }, props) { }

    public Body(string[] classes, object props) : base("BODY", classes, props) { }

    public Body(params string[] classes) : base("BODY", classes, null) { }

    public Body(object props) : base("BODY", new string[0], props) { }
  }

  /// <summary>
  /// HTML Br Tag
  /// </summary>
  public class Br : HtmlVoidElement
  {
    public Br(string className, object props) : base("BR", new[] { className }, props) { }

    public Br(string[] classes, object props) : base("BR", classes, props) { }

    public Br(params string[] classes) : base("BR", classes, null) { }

    public Br(object props) : base("BR", new string[0], props) { }
  }

  /// <summary>
  /// HTML Button Tag
  /// </summary>
  public class Button : HtmlElement
  {
    public Button(string className, object props) : base("BUTTON", new[] { className }, props) { }

    public Button(string[] classes, object props) : base("BUTTON", classes, props) { }

    public Button(params string[] classes) : base("BUTTON", classes, null) { }

    public Button(object props) : base("BUTTON", new string[0], props) { }
  }

  /// <summary>
  /// HTML Canvas Tag
  /// </summary>
  public class Canvas : HtmlElement
  {
    public Canvas(string className, object props) : base("CANVAS", new[] { className }, props) { }

    public Canvas(string[] classes, object props) : base("CANVAS", classes, props) { }

    public Canvas(params string[] classes) : base("CANVAS", classes, null) { }

    public Canvas(object props) : base("CANVAS", new string[0], props) { }
  }

  /// <summary>
  /// HTML Caption Tag
  /// </summary>
  public class Caption : HtmlElement
  {
    public Caption(string className, object props) : base("CAPTION", new[] { className }, props) { }

    public Caption(string[] classes, object props) : base("CAPTION", classes, props) { }

    public Caption(params string[] classes) : base("CAPTION", classes, null) { }

    public Caption(object props) : base("CAPTION", new string[0], props) { }
  }

  /// <summary>
  /// HTML Cite Tag
  /// </summary>
  public class Cite : HtmlElement
  {
    public Cite(string className, object props) : base("CITE", new[] { className }, props) { }

    public Cite(string[] classes, object props) : base("CITE", classes, props) { }

    public Cite(params string[] classes) : base("CITE", classes, null) { }

    public Cite(object props) : base("CITE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Code Tag
  /// </summary>
  public class Code : HtmlElement
  {
    public Code(string className, object props) : base("CODE", new[] { className }, props) { }

    public Code(string[] classes, object props) : base("CODE", classes, props) { }

    public Code(params string[] classes) : base("CODE", classes, null) { }

    public Code(object props) : base("CODE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Col Tag
  /// </summary>
  public class Col : HtmlVoidElement
  {
    public Col(string className, object props) : base("COL", new[] { className }, props) { }

    public Col(string[] classes, object props) : base("COL", classes, props) { }

    public Col(params string[] classes) : base("COL", classes, null) { }

    public Col(object props) : base("COL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Colgroup Tag
  /// </summary>
  public class Colgroup : HtmlElement
  {
    public Colgroup(string className, object props) : base("COLGROUP", new[] { className }, props) { }

    public Colgroup(string[] classes, object props) : base("COLGROUP", classes, props) { }

    public Colgroup(params string[] classes) : base("COLGROUP", classes, null) { }

    public Colgroup(object props) : base("COLGROUP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Command Tag
  /// </summary>
  public class Command : HtmlVoidElement
  {
    public Command(string className, object props) : base("COMMAND", new[] { className }, props) { }

    public Command(string[] classes, object props) : base("COMMAND", classes, props) { }

    public Command(params string[] classes) : base("COMMAND", classes, null) { }

    public Command(object props) : base("COMMAND", new string[0], props) { }
  }

  /// <summary>
  /// HTML Datalist Tag
  /// </summary>
  public class Datalist : HtmlElement
  {
    public Datalist(string className, object props) : base("DATALIST", new[] { className }, props) { }

    public Datalist(string[] classes, object props) : base("DATALIST", classes, props) { }

    public Datalist(params string[] classes) : base("DATALIST", classes, null) { }

    public Datalist(object props) : base("DATALIST", new string[0], props) { }
  }

  /// <summary>
  /// HTML Dd Tag
  /// </summary>
  public class Dd : HtmlElement
  {
    public Dd(string className, object props) : base("DD", new[] { className }, props) { }

    public Dd(string[] classes, object props) : base("DD", classes, props) { }

    public Dd(params string[] classes) : base("DD", classes, null) { }

    public Dd(object props) : base("DD", new string[0], props) { }
  }

  /// <summary>
  /// HTML Del Tag
  /// </summary>
  public class Del : HtmlElement
  {
    public Del(string className, object props) : base("DEL", new[] { className }, props) { }

    public Del(string[] classes, object props) : base("DEL", classes, props) { }

    public Del(params string[] classes) : base("DEL", classes, null) { }

    public Del(object props) : base("DEL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Details Tag
  /// </summary>
  public class Details : HtmlElement
  {
    public Details(string className, object props) : base("DETAILS", new[] { className }, props) { }

    public Details(string[] classes, object props) : base("DETAILS", classes, props) { }

    public Details(params string[] classes) : base("DETAILS", classes, null) { }

    public Details(object props) : base("DETAILS", new string[0], props) { }
  }

  /// <summary>
  /// HTML Dfn Tag
  /// </summary>
  public class Dfn : HtmlElement
  {
    public Dfn(string className, object props) : base("DFN", new[] { className }, props) { }

    public Dfn(string[] classes, object props) : base("DFN", classes, props) { }

    public Dfn(params string[] classes) : base("DFN", classes, null) { }

    public Dfn(object props) : base("DFN", new string[0], props) { }
  }

  /// <summary>
  /// HTML Div Tag
  /// </summary>
  public class Div : HtmlElement
  {
    public Div(string className, object props) : base("DIV", new[] { className }, props) { }

    public Div(string[] classes, object props) : base("DIV", classes, props) { }

    public Div(params string[] classes) : base("DIV", classes, null) { }

    public Div(object props) : base("DIV", new string[0], props) { }
  }

  /// <summary>
  /// HTML Dl Tag
  /// </summary>
  public class Dl : HtmlElement
  {
    public Dl(string className, object props) : base("DL", new[] { className }, props) { }

    public Dl(string[] classes, object props) : base("DL", classes, props) { }

    public Dl(params string[] classes) : base("DL", classes, null) { }

    public Dl(object props) : base("DL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Dt Tag
  /// </summary>
  public class Dt : HtmlElement
  {
    public Dt(string className, object props) : base("DT", new[] { className }, props) { }

    public Dt(string[] classes, object props) : base("DT", classes, props) { }

    public Dt(params string[] classes) : base("DT", classes, null) { }

    public Dt(object props) : base("DT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Em Tag
  /// </summary>
  public class Em : HtmlElement
  {
    public Em(string className, object props) : base("EM", new[] { className }, props) { }

    public Em(string[] classes, object props) : base("EM", classes, props) { }

    public Em(params string[] classes) : base("EM", classes, null) { }

    public Em(object props) : base("EM", new string[0], props) { }
  }

  /// <summary>
  /// HTML Embed Tag
  /// </summary>
  public class Embed : HtmlVoidElement
  {
    public Embed(string className, object props) : base("EMBED", new[] { className }, props) { }

    public Embed(string[] classes, object props) : base("EMBED", classes, props) { }

    public Embed(params string[] classes) : base("EMBED", classes, null) { }

    public Embed(object props) : base("EMBED", new string[0], props) { }
  }

  /// <summary>
  /// HTML Fieldset Tag
  /// </summary>
  public class Fieldset : HtmlElement
  {
    public Fieldset(string className, object props) : base("FIELDSET", new[] { className }, props) { }

    public Fieldset(string[] classes, object props) : base("FIELDSET", classes, props) { }

    public Fieldset(params string[] classes) : base("FIELDSET", classes, null) { }

    public Fieldset(object props) : base("FIELDSET", new string[0], props) { }
  }

  /// <summary>
  /// HTML Figcaption Tag
  /// </summary>
  public class Figcaption : HtmlElement
  {
    public Figcaption(string className, object props) : base("FIGCAPTION", new[] { className }, props) { }

    public Figcaption(string[] classes, object props) : base("FIGCAPTION", classes, props) { }

    public Figcaption(params string[] classes) : base("FIGCAPTION", classes, null) { }

    public Figcaption(object props) : base("FIGCAPTION", new string[0], props) { }
  }

  /// <summary>
  /// HTML Figure Tag
  /// </summary>
  public class Figure : HtmlElement
  {
    public Figure(string className, object props) : base("FIGURE", new[] { className }, props) { }

    public Figure(string[] classes, object props) : base("FIGURE", classes, props) { }

    public Figure(params string[] classes) : base("FIGURE", classes, null) { }

    public Figure(object props) : base("FIGURE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Footer Tag
  /// </summary>
  public class Footer : HtmlElement
  {
    public Footer(string className, object props) : base("FOOTER", new[] { className }, props) { }

    public Footer(string[] classes, object props) : base("FOOTER", classes, props) { }

    public Footer(params string[] classes) : base("FOOTER", classes, null) { }

    public Footer(object props) : base("FOOTER", new string[0], props) { }
  }

  /// <summary>
  /// HTML Form Tag
  /// </summary>
  public class Form : HtmlElement
  {
    public Form(string className, object props) : base("FORM", new[] { className }, props) { }

    public Form(string[] classes, object props) : base("FORM", classes, props) { }

    public Form(params string[] classes) : base("FORM", classes, null) { }

    public Form(object props) : base("FORM", new string[0], props) { }
  }

  /// <summary>
  /// HTML H1 Tag
  /// </summary>
  public class H1 : HtmlElement
  {
    public H1(string className, object props) : base("H1", new[] { className }, props) { }

    public H1(string[] classes, object props) : base("H1", classes, props) { }

    public H1(params string[] classes) : base("H1", classes, null) { }

    public H1(object props) : base("H1", new string[0], props) { }
  }

  /// <summary>
  /// HTML H2 Tag
  /// </summary>
  public class H2 : HtmlElement
  {
    public H2(string className, object props) : base("H2", new[] { className }, props) { }

    public H2(string[] classes, object props) : base("H2", classes, props) { }

    public H2(params string[] classes) : base("H2", classes, null) { }

    public H2(object props) : base("H2", new string[0], props) { }
  }

  /// <summary>
  /// HTML H3 Tag
  /// </summary>
  public class H3 : HtmlElement
  {
    public H3(string className, object props) : base("H3", new[] { className }, props) { }

    public H3(string[] classes, object props) : base("H3", classes, props) { }

    public H3(params string[] classes) : base("H3", classes, null) { }

    public H3(object props) : base("H3", new string[0], props) { }
  }

  /// <summary>
  /// HTML H4 Tag
  /// </summary>
  public class H4 : HtmlElement
  {
    public H4(string className, object props) : base("H4", new[] { className }, props) { }

    public H4(string[] classes, object props) : base("H4", classes, props) { }

    public H4(params string[] classes) : base("H4", classes, null) { }

    public H4(object props) : base("H4", new string[0], props) { }
  }

  /// <summary>
  /// HTML H5 Tag
  /// </summary>
  public class H5 : HtmlElement
  {
    public H5(string className, object props) : base("H5", new[] { className }, props) { }

    public H5(string[] classes, object props) : base("H5", classes, props) { }

    public H5(params string[] classes) : base("H5", classes, null) { }

    public H5(object props) : base("H5", new string[0], props) { }
  }

  /// <summary>
  /// HTML H6 Tag
  /// </summary>
  public class H6 : HtmlElement
  {
    public H6(string className, object props) : base("H6", new[] { className }, props) { }

    public H6(string[] classes, object props) : base("H6", classes, props) { }

    public H6(params string[] classes) : base("H6", classes, null) { }

    public H6(object props) : base("H6", new string[0], props) { }
  }

  /// <summary>
  /// HTML Head Tag
  /// </summary>
  public class Head : HtmlElement
  {
    public Head(string className, object props) : base("HEAD", new[] { className }, props) { }

    public Head(string[] classes, object props) : base("HEAD", classes, props) { }

    public Head(params string[] classes) : base("HEAD", classes, null) { }

    public Head(object props) : base("HEAD", new string[0], props) { }
  }

  /// <summary>
  /// HTML Header Tag
  /// </summary>
  public class Header : HtmlElement
  {
    public Header(string className, object props) : base("HEADER", new[] { className }, props) { }

    public Header(string[] classes, object props) : base("HEADER", classes, props) { }

    public Header(params string[] classes) : base("HEADER", classes, null) { }

    public Header(object props) : base("HEADER", new string[0], props) { }
  }

  /// <summary>
  /// HTML Hgroup Tag
  /// </summary>
  public class Hgroup : HtmlElement
  {
    public Hgroup(string className, object props) : base("HGROUP", new[] { className }, props) { }

    public Hgroup(string[] classes, object props) : base("HGROUP", classes, props) { }

    public Hgroup(params string[] classes) : base("HGROUP", classes, null) { }

    public Hgroup(object props) : base("HGROUP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Hr Tag
  /// </summary>
  public class Hr : HtmlVoidElement
  {
    public Hr(string className, object props) : base("HR", new[] { className }, props) { }

    public Hr(string[] classes, object props) : base("HR", classes, props) { }

    public Hr(params string[] classes) : base("HR", classes, null) { }

    public Hr(object props) : base("HR", new string[0], props) { }
  }

  /// <summary>
  /// HTML Html Tag
  /// </summary>
  public class Html : HtmlElement
  {
    public Html(string className, object props) : base("HTML", new[] { className }, props) { }

    public Html(string[] classes, object props) : base("HTML", classes, props) { }

    public Html(params string[] classes) : base("HTML", classes, null) { }

    public Html(object props) : base("HTML", new string[0], props) { }
  }

  /// <summary>
  /// HTML I Tag
  /// </summary>
  public class I : HtmlElement
  {
    public I(string className, object props) : base("I", new[] { className }, props) { }

    public I(string[] classes, object props) : base("I", classes, props) { }

    public I(params string[] classes) : base("I", classes, null) { }

    public I(object props) : base("I", new string[0], props) { }
  }

  /// <summary>
  /// HTML Iframe Tag
  /// </summary>
  public class Iframe : HtmlElement
  {
    public Iframe(string className, object props) : base("IFRAME", new[] { className }, props) { }

    public Iframe(string[] classes, object props) : base("IFRAME", classes, props) { }

    public Iframe(params string[] classes) : base("IFRAME", classes, null) { }

    public Iframe(object props) : base("IFRAME", new string[0], props) { }
  }

  /// <summary>
  /// HTML Img Tag
  /// </summary>
  public class Img : HtmlVoidElement
  {
    public Img(string className, object props) : base("IMG", new[] { className }, props) { }

    public Img(string[] classes, object props) : base("IMG", classes, props) { }

    public Img(params string[] classes) : base("IMG", classes, null) { }

    public Img(object props) : base("IMG", new string[0], props) { }
  }

  /// <summary>
  /// HTML Input Tag
  /// </summary>
  public class Input : HtmlVoidElement
  {
    public Input(string className, object props) : base("INPUT", new[] { className }, props) { }

    public Input(string[] classes, object props) : base("INPUT", classes, props) { }

    public Input(params string[] classes) : base("INPUT", classes, null) { }

    public Input(object props) : base("INPUT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Ins Tag
  /// </summary>
  public class Ins : HtmlElement
  {
    public Ins(string className, object props) : base("INS", new[] { className }, props) { }

    public Ins(string[] classes, object props) : base("INS", classes, props) { }

    public Ins(params string[] classes) : base("INS", classes, null) { }

    public Ins(object props) : base("INS", new string[0], props) { }
  }

  /// <summary>
  /// HTML Kbd Tag
  /// </summary>
  public class Kbd : HtmlElement
  {
    public Kbd(string className, object props) : base("KBD", new[] { className }, props) { }

    public Kbd(string[] classes, object props) : base("KBD", classes, props) { }

    public Kbd(params string[] classes) : base("KBD", classes, null) { }

    public Kbd(object props) : base("KBD", new string[0], props) { }
  }

  /// <summary>
  /// HTML Keygen Tag
  /// </summary>
  public class Keygen : HtmlVoidElement
  {
    public Keygen(string className, object props) : base("KEYGEN", new[] { className }, props) { }

    public Keygen(string[] classes, object props) : base("KEYGEN", classes, props) { }

    public Keygen(params string[] classes) : base("KEYGEN", classes, null) { }

    public Keygen(object props) : base("KEYGEN", new string[0], props) { }
  }

  /// <summary>
  /// HTML Label Tag
  /// </summary>
  public class Label : HtmlElement
  {
    public Label(string className, object props) : base("LABEL", new[] { className }, props) { }

    public Label(string[] classes, object props) : base("LABEL", classes, props) { }

    public Label(params string[] classes) : base("LABEL", classes, null) { }

    public Label(object props) : base("LABEL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Legend Tag
  /// </summary>
  public class Legend : HtmlElement
  {
    public Legend(string className, object props) : base("LEGEND", new[] { className }, props) { }

    public Legend(string[] classes, object props) : base("LEGEND", classes, props) { }

    public Legend(params string[] classes) : base("LEGEND", classes, null) { }

    public Legend(object props) : base("LEGEND", new string[0], props) { }
  }

  /// <summary>
  /// HTML Li Tag
  /// </summary>
  public class Li : HtmlElement
  {
    public Li(string className, object props) : base("LI", new[] { className }, props) { }

    public Li(string[] classes, object props) : base("LI", classes, props) { }

    public Li(params string[] classes) : base("LI", classes, null) { }

    public Li(object props) : base("LI", new string[0], props) { }
  }

  /// <summary>
  /// HTML Link Tag
  /// </summary>
  public class Link : HtmlVoidElement
  {
    public Link(string className, object props) : base("LINK", new[] { className }, props) { }

    public Link(string[] classes, object props) : base("LINK", classes, props) { }

    public Link(params string[] classes) : base("LINK", classes, null) { }

    public Link(object props) : base("LINK", new string[0], props) { }
  }

  /// <summary>
  /// HTML Main Tag
  /// </summary>
  public class Main : HtmlElement
  {
    public Main(string className, object props) : base("MAIN", new[] { className }, props) { }

    public Main(string[] classes, object props) : base("MAIN", classes, props) { }

    public Main(params string[] classes) : base("MAIN", classes, null) { }

    public Main(object props) : base("MAIN", new string[0], props) { }
  }

  /// <summary>
  /// HTML Map Tag
  /// </summary>
  public class Map : HtmlElement
  {
    public Map(string className, object props) : base("MAP", new[] { className }, props) { }

    public Map(string[] classes, object props) : base("MAP", classes, props) { }

    public Map(params string[] classes) : base("MAP", classes, null) { }

    public Map(object props) : base("MAP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Mark Tag
  /// </summary>
  public class Mark : HtmlElement
  {
    public Mark(string className, object props) : base("MARK", new[] { className }, props) { }

    public Mark(string[] classes, object props) : base("MARK", classes, props) { }

    public Mark(params string[] classes) : base("MARK", classes, null) { }

    public Mark(object props) : base("MARK", new string[0], props) { }
  }

  /// <summary>
  /// HTML Menu Tag
  /// </summary>
  public class Menu : HtmlElement
  {
    public Menu(string className, object props) : base("MENU", new[] { className }, props) { }

    public Menu(string[] classes, object props) : base("MENU", classes, props) { }

    public Menu(params string[] classes) : base("MENU", classes, null) { }

    public Menu(object props) : base("MENU", new string[0], props) { }
  }

  /// <summary>
  /// HTML Meta Tag
  /// </summary>
  public class Meta : HtmlVoidElement
  {
    public Meta(string className, object props) : base("META", new[] { className }, props) { }

    public Meta(string[] classes, object props) : base("META", classes, props) { }

    public Meta(params string[] classes) : base("META", classes, null) { }

    public Meta(object props) : base("META", new string[0], props) { }
  }

  /// <summary>
  /// HTML Meter Tag
  /// </summary>
  public class Meter : HtmlElement
  {
    public Meter(string className, object props) : base("METER", new[] { className }, props) { }

    public Meter(string[] classes, object props) : base("METER", classes, props) { }

    public Meter(params string[] classes) : base("METER", classes, null) { }

    public Meter(object props) : base("METER", new string[0], props) { }
  }

  /// <summary>
  /// HTML Nav Tag
  /// </summary>
  public class Nav : HtmlElement
  {
    public Nav(string className, object props) : base("NAV", new[] { className }, props) { }

    public Nav(string[] classes, object props) : base("NAV", classes, props) { }

    public Nav(params string[] classes) : base("NAV", classes, null) { }

    public Nav(object props) : base("NAV", new string[0], props) { }
  }

  /// <summary>
  /// HTML Noscript Tag
  /// </summary>
  public class Noscript : HtmlElement
  {
    public Noscript(string className, object props) : base("NOSCRIPT", new[] { className }, props) { }

    public Noscript(string[] classes, object props) : base("NOSCRIPT", classes, props) { }

    public Noscript(params string[] classes) : base("NOSCRIPT", classes, null) { }

    public Noscript(object props) : base("NOSCRIPT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Object Tag
  /// </summary>
  public class Object : HtmlElement
  {
    public Object(string className, object props) : base("OBJECT", new[] { className }, props) { }

    public Object(string[] classes, object props) : base("OBJECT", classes, props) { }

    public Object(params string[] classes) : base("OBJECT", classes, null) { }

    public Object(object props) : base("OBJECT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Ol Tag
  /// </summary>
  public class Ol : HtmlElement
  {
    public Ol(string className, object props) : base("OL", new[] { className }, props) { }

    public Ol(string[] classes, object props) : base("OL", classes, props) { }

    public Ol(params string[] classes) : base("OL", classes, null) { }

    public Ol(object props) : base("OL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Optgroup Tag
  /// </summary>
  public class Optgroup : HtmlElement
  {
    public Optgroup(string className, object props) : base("OPTGROUP", new[] { className }, props) { }

    public Optgroup(string[] classes, object props) : base("OPTGROUP", classes, props) { }

    public Optgroup(params string[] classes) : base("OPTGROUP", classes, null) { }

    public Optgroup(object props) : base("OPTGROUP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Option Tag
  /// </summary>
  public class Option : HtmlElement
  {
    public Option(string className, object props) : base("OPTION", new[] { className }, props) { }

    public Option(string[] classes, object props) : base("OPTION", classes, props) { }

    public Option(params string[] classes) : base("OPTION", classes, null) { }

    public Option(object props) : base("OPTION", new string[0], props) { }
  }

  /// <summary>
  /// HTML Output Tag
  /// </summary>
  public class Output : HtmlElement
  {
    public Output(string className, object props) : base("OUTPUT", new[] { className }, props) { }

    public Output(string[] classes, object props) : base("OUTPUT", classes, props) { }

    public Output(params string[] classes) : base("OUTPUT", classes, null) { }

    public Output(object props) : base("OUTPUT", new string[0], props) { }
  }

  /// <summary>
  /// HTML P Tag
  /// </summary>
  public class P : HtmlElement
  {
    public P(string className, object props) : base("P", new[] { className }, props) { }

    public P(string[] classes, object props) : base("P", classes, props) { }

    public P(params string[] classes) : base("P", classes, null) { }

    public P(object props) : base("P", new string[0], props) { }
  }

  /// <summary>
  /// HTML Param Tag
  /// </summary>
  public class Param : HtmlVoidElement
  {
    public Param(string className, object props) : base("PARAM", new[] { className }, props) { }

    public Param(string[] classes, object props) : base("PARAM", classes, props) { }

    public Param(params string[] classes) : base("PARAM", classes, null) { }

    public Param(object props) : base("PARAM", new string[0], props) { }
  }

  /// <summary>
  /// HTML Pre Tag
  /// </summary>
  public class Pre : HtmlElement
  {
    public Pre(string className, object props) : base("PRE", new[] { className }, props) { }

    public Pre(string[] classes, object props) : base("PRE", classes, props) { }

    public Pre(params string[] classes) : base("PRE", classes, null) { }

    public Pre(object props) : base("PRE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Progress Tag
  /// </summary>
  public class Progress : HtmlElement
  {
    public Progress(string className, object props) : base("PROGRESS", new[] { className }, props) { }

    public Progress(string[] classes, object props) : base("PROGRESS", classes, props) { }

    public Progress(params string[] classes) : base("PROGRESS", classes, null) { }

    public Progress(object props) : base("PROGRESS", new string[0], props) { }
  }

  /// <summary>
  /// HTML Q Tag
  /// </summary>
  public class Q : HtmlElement
  {
    public Q(string className, object props) : base("Q", new[] { className }, props) { }

    public Q(string[] classes, object props) : base("Q", classes, props) { }

    public Q(params string[] classes) : base("Q", classes, null) { }

    public Q(object props) : base("Q", new string[0], props) { }
  }

  /// <summary>
  /// HTML Rp Tag
  /// </summary>
  public class Rp : HtmlElement
  {
    public Rp(string className, object props) : base("RP", new[] { className }, props) { }

    public Rp(string[] classes, object props) : base("RP", classes, props) { }

    public Rp(params string[] classes) : base("RP", classes, null) { }

    public Rp(object props) : base("RP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Rt Tag
  /// </summary>
  public class Rt : HtmlElement
  {
    public Rt(string className, object props) : base("RT", new[] { className }, props) { }

    public Rt(string[] classes, object props) : base("RT", classes, props) { }

    public Rt(params string[] classes) : base("RT", classes, null) { }

    public Rt(object props) : base("RT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Ruby Tag
  /// </summary>
  public class Ruby : HtmlElement
  {
    public Ruby(string className, object props) : base("RUBY", new[] { className }, props) { }

    public Ruby(string[] classes, object props) : base("RUBY", classes, props) { }

    public Ruby(params string[] classes) : base("RUBY", classes, null) { }

    public Ruby(object props) : base("RUBY", new string[0], props) { }
  }

  /// <summary>
  /// HTML S Tag
  /// </summary>
  public class S : HtmlElement
  {
    public S(string className, object props) : base("S", new[] { className }, props) { }

    public S(string[] classes, object props) : base("S", classes, props) { }

    public S(params string[] classes) : base("S", classes, null) { }

    public S(object props) : base("S", new string[0], props) { }
  }

  /// <summary>
  /// HTML Samp Tag
  /// </summary>
  public class Samp : HtmlElement
  {
    public Samp(string className, object props) : base("SAMP", new[] { className }, props) { }

    public Samp(string[] classes, object props) : base("SAMP", classes, props) { }

    public Samp(params string[] classes) : base("SAMP", classes, null) { }

    public Samp(object props) : base("SAMP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Script Tag
  /// </summary>
  public class Script : HtmlElement
  {
    public Script(string className, object props) : base("SCRIPT", new[] { className }, props) { }

    public Script(string[] classes, object props) : base("SCRIPT", classes, props) { }

    public Script(params string[] classes) : base("SCRIPT", classes, null) { }

    public Script(object props) : base("SCRIPT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Section Tag
  /// </summary>
  public class Section : HtmlElement
  {
    public Section(string className, object props) : base("SECTION", new[] { className }, props) { }

    public Section(string[] classes, object props) : base("SECTION", classes, props) { }

    public Section(params string[] classes) : base("SECTION", classes, null) { }

    public Section(object props) : base("SECTION", new string[0], props) { }
  }

  /// <summary>
  /// HTML Select Tag
  /// </summary>
  public class Select : HtmlElement
  {
    public Select(string className, object props) : base("SELECT", new[] { className }, props) { }

    public Select(string[] classes, object props) : base("SELECT", classes, props) { }

    public Select(params string[] classes) : base("SELECT", classes, null) { }

    public Select(object props) : base("SELECT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Small Tag
  /// </summary>
  public class Small : HtmlElement
  {
    public Small(string className, object props) : base("SMALL", new[] { className }, props) { }

    public Small(string[] classes, object props) : base("SMALL", classes, props) { }

    public Small(params string[] classes) : base("SMALL", classes, null) { }

    public Small(object props) : base("SMALL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Source Tag
  /// </summary>
  public class Source : HtmlVoidElement
  {
    public Source(string className, object props) : base("SOURCE", new[] { className }, props) { }

    public Source(string[] classes, object props) : base("SOURCE", classes, props) { }

    public Source(params string[] classes) : base("SOURCE", classes, null) { }

    public Source(object props) : base("SOURCE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Span Tag
  /// </summary>
  public class Span : HtmlElement
  {
    public Span(string className, object props) : base("SPAN", new[] { className }, props) { }

    public Span(string[] classes, object props) : base("SPAN", classes, props) { }

    public Span(params string[] classes) : base("SPAN", classes, null) { }

    public Span(object props) : base("SPAN", new string[0], props) { }
  }

  /// <summary>
  /// HTML Strong Tag
  /// </summary>
  public class Strong : HtmlElement
  {
    public Strong(string className, object props) : base("STRONG", new[] { className }, props) { }

    public Strong(string[] classes, object props) : base("STRONG", classes, props) { }

    public Strong(params string[] classes) : base("STRONG", classes, null) { }

    public Strong(object props) : base("STRONG", new string[0], props) { }
  }

  /// <summary>
  /// HTML Style Tag
  /// </summary>
  public class Style : HtmlElement
  {
    public Style(string className, object props) : base("STYLE", new[] { className }, props) { }

    public Style(string[] classes, object props) : base("STYLE", classes, props) { }

    public Style(params string[] classes) : base("STYLE", classes, null) { }

    public Style(object props) : base("STYLE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Sub Tag
  /// </summary>
  public class Sub : HtmlElement
  {
    public Sub(string className, object props) : base("SUB", new[] { className }, props) { }

    public Sub(string[] classes, object props) : base("SUB", classes, props) { }

    public Sub(params string[] classes) : base("SUB", classes, null) { }

    public Sub(object props) : base("SUB", new string[0], props) { }
  }

  /// <summary>
  /// HTML Summary Tag
  /// </summary>
  public class Summary : HtmlElement
  {
    public Summary(string className, object props) : base("SUMMARY", new[] { className }, props) { }

    public Summary(string[] classes, object props) : base("SUMMARY", classes, props) { }

    public Summary(params string[] classes) : base("SUMMARY", classes, null) { }

    public Summary(object props) : base("SUMMARY", new string[0], props) { }
  }

  /// <summary>
  /// HTML Sup Tag
  /// </summary>
  public class Sup : HtmlElement
  {
    public Sup(string className, object props) : base("SUP", new[] { className }, props) { }

    public Sup(string[] classes, object props) : base("SUP", classes, props) { }

    public Sup(params string[] classes) : base("SUP", classes, null) { }

    public Sup(object props) : base("SUP", new string[0], props) { }
  }

  /// <summary>
  /// HTML Table Tag
  /// </summary>
  public class Table : HtmlElement
  {
    public Table(string className, object props) : base("TABLE", new[] { className }, props) { }

    public Table(string[] classes, object props) : base("TABLE", classes, props) { }

    public Table(params string[] classes) : base("TABLE", classes, null) { }

    public Table(object props) : base("TABLE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Tbody Tag
  /// </summary>
  public class Tbody : HtmlElement
  {
    public Tbody(string className, object props) : base("TBODY", new[] { className }, props) { }

    public Tbody(string[] classes, object props) : base("TBODY", classes, props) { }

    public Tbody(params string[] classes) : base("TBODY", classes, null) { }

    public Tbody(object props) : base("TBODY", new string[0], props) { }
  }

  /// <summary>
  /// HTML Td Tag
  /// </summary>
  public class Td : HtmlElement
  {
    public Td(string className, object props) : base("TD", new[] { className }, props) { }

    public Td(string[] classes, object props) : base("TD", classes, props) { }

    public Td(params string[] classes) : base("TD", classes, null) { }

    public Td(object props) : base("TD", new string[0], props) { }
  }

  /// <summary>
  /// HTML Textarea Tag
  /// </summary>
  public class Textarea : HtmlElement
  {
    public Textarea(string className, object props) : base("TEXTAREA", new[] { className }, props) { }

    public Textarea(string[] classes, object props) : base("TEXTAREA", classes, props) { }

    public Textarea(params string[] classes) : base("TEXTAREA", classes, null) { }

    public Textarea(object props) : base("TEXTAREA", new string[0], props) { }
  }

  /// <summary>
  /// HTML Tfoot Tag
  /// </summary>
  public class Tfoot : HtmlElement
  {
    public Tfoot(string className, object props) : base("TFOOT", new[] { className }, props) { }

    public Tfoot(string[] classes, object props) : base("TFOOT", classes, props) { }

    public Tfoot(params string[] classes) : base("TFOOT", classes, null) { }

    public Tfoot(object props) : base("TFOOT", new string[0], props) { }
  }

  /// <summary>
  /// HTML Th Tag
  /// </summary>
  public class Th : HtmlElement
  {
    public Th(string className, object props) : base("TH", new[] { className }, props) { }

    public Th(string[] classes, object props) : base("TH", classes, props) { }

    public Th(params string[] classes) : base("TH", classes, null) { }

    public Th(object props) : base("TH", new string[0], props) { }
  }

  /// <summary>
  /// HTML Thead Tag
  /// </summary>
  public class Thead : HtmlElement
  {
    public Thead(string className, object props) : base("THEAD", new[] { className }, props) { }

    public Thead(string[] classes, object props) : base("THEAD", classes, props) { }

    public Thead(params string[] classes) : base("THEAD", classes, null) { }

    public Thead(object props) : base("THEAD", new string[0], props) { }
  }

  /// <summary>
  /// HTML Time Tag
  /// </summary>
  public class Time : HtmlElement
  {
    public Time(string className, object props) : base("TIME", new[] { className }, props) { }

    public Time(string[] classes, object props) : base("TIME", classes, props) { }

    public Time(params string[] classes) : base("TIME", classes, null) { }

    public Time(object props) : base("TIME", new string[0], props) { }
  }

  /// <summary>
  /// HTML Title Tag
  /// </summary>
  public class Title : HtmlElement
  {
    public Title(string className, object props) : base("TITLE", new[] { className }, props) { }

    public Title(string[] classes, object props) : base("TITLE", classes, props) { }

    public Title(params string[] classes) : base("TITLE", classes, null) { }

    public Title(object props) : base("TITLE", new string[0], props) { }
  }

  /// <summary>
  /// HTML Tr Tag
  /// </summary>
  public class Tr : HtmlElement
  {
    public Tr(string className, object props) : base("TR", new[] { className }, props) { }

    public Tr(string[] classes, object props) : base("TR", classes, props) { }

    public Tr(params string[] classes) : base("TR", classes, null) { }

    public Tr(object props) : base("TR", new string[0], props) { }
  }

  /// <summary>
  /// HTML Track Tag
  /// </summary>
  public class Track : HtmlVoidElement
  {
    public Track(string className, object props) : base("TRACK", new[] { className }, props) { }

    public Track(string[] classes, object props) : base("TRACK", classes, props) { }

    public Track(params string[] classes) : base("TRACK", classes, null) { }

    public Track(object props) : base("TRACK", new string[0], props) { }
  }

  /// <summary>
  /// HTML U Tag
  /// </summary>
  public class U : HtmlElement
  {
    public U(string className, object props) : base("U", new[] { className }, props) { }

    public U(string[] classes, object props) : base("U", classes, props) { }

    public U(params string[] classes) : base("U", classes, null) { }

    public U(object props) : base("U", new string[0], props) { }
  }

  /// <summary>
  /// HTML Ul Tag
  /// </summary>
  public class Ul : HtmlElement
  {
    public Ul(string className, object props) : base("UL", new[] { className }, props) { }

    public Ul(string[] classes, object props) : base("UL", classes, props) { }

    public Ul(params string[] classes) : base("UL", classes, null) { }

    public Ul(object props) : base("UL", new string[0], props) { }
  }

  /// <summary>
  /// HTML Var Tag
  /// </summary>
  public class Var : HtmlElement
  {
    public Var(string className, object props) : base("VAR", new[] { className }, props) { }

    public Var(string[] classes, object props) : base("VAR", classes, props) { }

    public Var(params string[] classes) : base("VAR", classes, null) { }

    public Var(object props) : base("VAR", new string[0], props) { }
  }

  /// <summary>
  /// HTML Video Tag
  /// </summary>
  public class Video : HtmlElement
  {
    public Video(string className, object props) : base("VIDEO", new[] { className }, props) { }

    public Video(string[] classes, object props) : base("VIDEO", classes, props) { }

    public Video(params string[] classes) : base("VIDEO", classes, null) { }

    public Video(object props) : base("VIDEO", new string[0], props) { }
  }

  /// <summary>
  /// HTML Wbr Tag
  /// </summary>
  public class Wbr : HtmlVoidElement
  {
    public Wbr(string className, object props) : base("WBR", new[] { className }, props) { }

    public Wbr(string[] classes, object props) : base("WBR", classes, props) { }

    public Wbr(params string[] classes) : base("WBR", classes, null) { }

    public Wbr(object props) : base("WBR", new string[0], props) { }
  }

}