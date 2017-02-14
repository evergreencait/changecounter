using System;
using Xunit;
using System.Collections.Generic;

namespace CoinCombo.Objects
{
  public class Change
  {
    private int _changeInput;

    public Change(int change)
    {
      _changeInput = change;
    }

      public int[] CountChange ()
      {
        int[] _changeArray = {0, 0, 0 ,0};
        var maxQuarters = (_changeInput/25);
        _changeArray[0] = maxQuarters;

        return _changeArray;
      }
  }
}
