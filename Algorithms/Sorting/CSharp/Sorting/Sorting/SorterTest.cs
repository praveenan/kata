namespace Sorting
{
  using System;
  using System.Linq;

  using NUnit.Framework;

  [TestFixture]
  public class SorterTest
  {
    private int[] array;

    /// <summary>
    /// The length of array
    /// </summary>
    private int arrayLength = 1000000;

    [SetUp]
    public void SetUp()
    {
      var random = new Random();
      this.array = new int[arrayLength];

      for (var i = 0; i < this.arrayLength; i++)
      {
        this.array[i] = random.Next();
      }
    }

    [Test]
    public void Quicksort()
    {
      Assert.IsFalse(this.array.IsSorted());

      Sorter.Quicksort(this.array);

      Assert.IsTrue(this.array.IsSorted());
    }
  }

  public static class ArrayExtensions
  {
    public static bool IsSorted(this int[] array)
    {
      return !array.Where((t, i) => i != 0 && array[i - 1] > t).Any();
    }
  }
}
