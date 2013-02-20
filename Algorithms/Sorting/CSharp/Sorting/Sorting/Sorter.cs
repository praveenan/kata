namespace Sorting
{
  using System;

  public class Sorter
  {
    public static void Quicksort(int[] array, int left = 0, int right = -1)
    {
      // Do nothing if we have null or empty array
      if (array == null || array.Length == 0)
      {
        return;
      }

      // Handle default value of method parameter
      if (right < 0)
      {
        // If right is not specified, set it to the last element of array
        right = array.Length - 1;
      }

      var i = left;
      var j = right;

      // For a pivot we take a random element of array
      var pivot = array[new Random().Next(left, right)];

      // While i is on left from j
      while (i <= j)
      {
        // In whis way we are finding first element from the left side
        // of array what is greater than pivot.
        // So we have to move it to the right.
        while (array[i] < pivot)
        {
          i++;
        }

        // In this way we are finding first element from the right side
        // of array what is less than pivot.
        // So we have to move it to the left.
        while (array[j] > pivot)
        {
          j--;
        }

        // If i is still on the left from j or on the same position,
        // swap array elements
        if (i < j)
        {
          var temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        }

        // And move i to the right and j to the left
        // if i is still not on the right from the j.
        if (i <= j)
        {
          i++;
          j--;
        }
      }

      // So here we have i > j
      // and we sort left part of array - [left..j]
      if (left < j)
      {
        Quicksort(array, left, j);
      }

      // Or, if j <= left, let's sort right part of array - [i..right]
      if (i < right)
      {
        Quicksort(array, i, right);
      }

      // Otherwise, left and right parts are sorted, there is nothing to do here
    }
  }
}
