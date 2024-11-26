//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 素朴なソートアルゴリズムメニュー **********/
//    //挿入ソート
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //SelectionSort(A, n);

//    //選択ソート
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //SelectionSort(A, n);

//    //バブルソート
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //BubbleSort(A, n);
//  }

//  //バブルソート
//  private static void BubbleSort(int[] A, int n)
//  {
//    for (int i = 0; i < n - 1; i++)
//    {
//      for (int j = n - 1; j >= i + 1; j--)
//      {
//        if (A[j] < A[j - 1])
//        {
//          int temp = A[j];
//          A[j] = A[j - 1];
//          A[j - 1] = temp;
//        }
//      }
//      Console.WriteLine(string.Join(" ", A));
//    }
//  }

//  //選択ソート
//  private static void SelectionSort(int[] A, int n)
//  {
//    for (int i = 0; i < n - 1; i++)
//    {
//      int minIndex = i;
//      for (int j = i + 1; j < n; j++)
//      {
//        if (A[j] < A[minIndex])
//        {
//          minIndex = j;
//        }
//      }
//      //Swap（タプルでも行える）
//      int temp = A[minIndex];
//      A[minIndex] = A[i];
//      A[i] = temp;
//      Console.WriteLine(string.Join(" ", A));
//    }
//  }

//  //挿入ソート
//  private static void InsertionSort(int[] A, int n)
//  {
//    for (int i = 1; i < n; i++)
//    {
//      int x = A[i];
//      int j = i - 1;

//      while (j >= 0 && A[j] > x)
//      {
//        A[j + 1] = A[j];
//        j--;
//      }
//      A[j + 1] = x;
//      Console.WriteLine(string.Join(" ", A));
//    }
//  }
//}