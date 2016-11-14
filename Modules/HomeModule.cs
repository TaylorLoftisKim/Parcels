using Nancy;
using System.Collections.Generic;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/story"] = _ => {
        ParcelVariables myParcelVariables = new ParcelVariables();
        myParcelVariables.SetHeight(Request.Query["height"]);
        myParcelVariables.SetLength(Request.Query["length"]);
        myParcelVariables.SetWidth(Request.Query["width"]);
        myParcelVariables.SetWeight(Request.Query["weight"]);
        return View["output.cshtml", myParcelVariables];
      };
    }
  }
}
