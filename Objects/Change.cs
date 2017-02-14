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
        int maxQuarters = (_changeInput/25);
        _changeArray[0] = maxQuarters;
        int dimeChange = _changeInput - (25 * maxQuarters);
        int maxDimes = (dimeChange/10);
        _changeArray[1] = maxDimes;
        int nickelChange = dimeChange - (10 * maxDimes);
        int maxNickels = (nickelChange/5);
        _changeArray[2] = maxNickels;

        return _changeArray;
      }
  }
}
