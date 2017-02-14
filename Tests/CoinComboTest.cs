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
      Change ChangeTest = new Change(85);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }

    [Fact]
    public void CountChange_ReturnQuarterAndDimeAndNickel_true()
    {
      int[] changeInt = new int[] {0, 1, 1, 0};
      Change ChangeTest = new Change(15);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }

    [Fact]
    public void CountChange_ReturnQuarterAndDimeAndNickelAndPenny_true()
    {
      int[] changeInt = new int[] {3, 1, 1, 4};
      Change ChangeTest = new Change(94);
      Assert.Equal(changeInt, ChangeTest.CountChange());
    }
  }
}
