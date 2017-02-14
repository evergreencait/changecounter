using Nancy;
using CoinCombo.Objects;
using System.Collections.Generic;

namespace CoinCombo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        Change newChange = new Change(Request.Form["change-input"]);
        List<int> changeInfo = new List<int>();
        int[] changeArray = newChange.CountChange();
        for (int i = 0; i < changeArray.Length; i++)
        {
          changeInfo.Add(changeArray[i]);
        }
        changeInfo.Add(newChange.GetInput());
        return View["/results", changeInfo];
      };
    }
  }
}
