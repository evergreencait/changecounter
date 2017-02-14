using Xunit;
using System.Collections.Generic;

namespace CoinCombo.Objects
{
  public class CoinComboTest
  {
    [Fact]
    public void CountChange_ReturnQuarter_true()
    {
      int[] changeInt = new int[] {3, 0, 0, 0};
      Change ChangeTest = new Change(90);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }
  }
}
