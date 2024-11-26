//using System;
//using System.Linq;

//class Program
//{
//  static int count = 0;
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 効率的なソートアルゴリズムメニュー **********/
//    //シェルソート
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //ShellSort(A, n, h);

//    //マージソート
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //MergeSort(A, 0, n);
//    //Console.WriteLine(string.Join(" ", A));
//    //Console.WriteLine(count);

//    //クイックソート
//    int n = int.Parse(Console.ReadLine());
//    int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    QuickSort(A, 0, n);
//    Console.WriteLine(string.Join(" ", A));
//    Console.WriteLine(count);
//  }

//  //シェルソート
//  private static void ShellSort(int[] A, int n, int[] h)
//  {
//    foreach (var hi in h)
//    {
//      InsertionSort(A, n, hi);
//    }
//  }
//  private static void InsertionSort(int[] A, int n, int hi)
//  {
//    int numOfMove = 0;
//    for (int i = hi; i < n; i++)
//    {
//      int x = A[i];
//      int j = i - hi;

//      while (j >= 0 && A[j] > x)
//      {
//        A[j + hi] = A[j];
//        j -= hi;
//        numOfMove++;
//      }
//      A[j + hi] = x;
//    }
//    Console.WriteLine(numOfMove);
//  }

//  //マージソート
//  private static void MergeSort(int[] A, int left, int right)
//  {
//    if (left + 1 < right)
//    {
//      int mid = (left + right) / 2;
//      MergeSort(A, left, mid);
//      MergeSort(A, mid, right);
//      Merge(A, left, mid, right);
//    }
//  }
//  private static void Merge(int[] A, int left, int mid, int right)
//  {
//    int nl = mid - left;
//    int nr = right - mid;
//    int[] L = new int[nl + 1];
//    int[] R = new int[nr + 1];

//    for (int i = 0; i < nl; i++)
//    {
//      L[i] = A[left + i];
//    }
//    for (int i = 0; i < nr; i++)
//    {
//      R[i] = A[mid + i];
//    }

//    L[nl] = int.MaxValue;
//    R[nr] = int.MaxValue;

//    int lindex = 0;
//    int rindex = 0;

//    for (int i = left; i < right; i++)
//    {
//      if (L[lindex] < R[rindex])
//      {
//        A[i] = L[lindex];
//        lindex++;
//      }
//      else
//      {
//        A[i] = R[rindex];
//        rindex++;
//        count++;
//      }
//    }
//  }

//  //クイックソート
//  private static void QuickSort(int[] A, int left, int right)
//  {
//    if (left + 1 >= right) return;

//    int pivod = A[right - 1];

//    int curIndex = left;

//    for (int i = left; i < right - 1; i++)
//    {
//      if (A[i] < pivod)
//      {
//        Swap(A, curIndex, i);
//        curIndex++;
//        count++;
//      }
//    }
//    Swap(A, curIndex, right - 1);

//    QuickSort(A, left, curIndex);
//    QuickSort(A, curIndex + 1, right);
//  }
//  private static void Swap(int[] A, int x, int y)
//  {
//    int temp = A[y];
//    A[y] = A[x];
//    A[x] = temp;
//  }
//}