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
      Change ChangeTest = new Change(75);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }

    [Fact]
    public void CountChange_ReturnQuarterAndDime_true()
    {
      int[] changeInt = new int[] {3, 1, 0, 0};
      Change ChangeTest = new Change(90);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }
  }
}
