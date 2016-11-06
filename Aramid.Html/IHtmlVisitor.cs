using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aramid.Html;

namespace Aramid
{
  public interface IHtmlVisitor
  {
    void Visit(IHtmlNode element);
  }
}
