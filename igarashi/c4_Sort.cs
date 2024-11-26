//public class Example
//{
//  public static void Main()
//  {
//    int[] A = { 18, 35, 76, 23, 49, 42, 31, 12 };
//    Sort.BubbleSort(A, A.Length);
//    Sort.QuickSort(A, 0, A.Length);
//    Console.WriteLine(string.Join(" ", A));
//  }
//}

public class Sort
{
  //バブルソート
  public static void BubbleSort(int[] A, int n)
  {
    for (int i = 0; i < n - 1; i++)
    {
      for (int j = n - 1; j >= i + 1; j--)
      {
        if (A[j] < A[j - 1])
        {
          int temp = A[j];
          A[j] = A[j - 1];
          A[j - 1] = temp;
        }
      }
    }
  }

  //クイックソート
  public static void QuickSort(int[] A, int left, int right)
  {
    if (left + 1 >= right) return;

    int pivod = A[right - 1];

    int curIndex = left;

    for (int i = left; i < right - 1; i++)
    {
      if (A[i] < pivod)
      {
        Swap(A, curIndex, i);
        curIndex++;
      }
    }
    Swap(A, curIndex, right - 1);

    QuickSort(A, left, curIndex);
    QuickSort(A, curIndex + 1, right);
  }
  private static void Swap(int[] A, int x, int y)
  {
    int temp = A[y];
    A[y] = A[x];
    A[x] = temp;
  }
}