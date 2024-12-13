//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** ある範囲に含まれている整数の個数 **************/
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Array.Sort(A);
//    //int q = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < q; i++)
//    //{
//    //int k = int.Parse(Console.ReadLine());
//    //int index = Array.BinarySearch(A, k);
//    //Console.WriteLine(index >= 0 ? "Yes" : "No");
//    //Console.WriteLine(BinarySerch(A, n, k) ? "Yes" : "No");
//    //Console.WriteLine(n - LowerBound(A, n, k));
//    //Console.WriteLine(n - UpperBound(A, n, k));
//    //int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int l = lr[0], r = lr[1];
//    //int lindex = LowerBound(A, n, l);
//    //int rindex = UpperBound(A, n, r);
//    //Console.WriteLine(rindex - lindex);
//    //}

//    /********** 長い長い数列 **************/
//    //STEP: 1 パイプを切り出そう
//    //   int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  Console.WriteLine(PipeMax(A, nk[0], nk[1]));

//    //STEP: 2 効率よく盗もう
//    //int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] W = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] V = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(ValueMax(W, V, nk[0], nk[1]));

//    //STEP: 3 太巻きを分けよう (おなかペコペコ)
//    //STEP: 4 太巻きを分けよう (おなかいっぱい)
//    //int[] Lnk = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(HungryMin(A, Lnk[0], Lnk[1], Lnk[2]));
//    //Console.WriteLine(HungryMax(A, Lnk[0], Lnk[1], Lnk[2]));

//    //FINAL問題 長い長い数列
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int m = int.Parse(Console.ReadLine());
//    //int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Array.Sort(B);
//    //int k = int.Parse(Console.ReadLine());
//    //Console.WriteLine(LongLongAB(A, n, B, m, k));
//  }

//  /********** ある範囲に含まれている整数の個数 **************/
//  //STEP: 1 値の探索
//  private static bool BinarySerch(int[] A, int n, int k)
//  {
//    bool check = false;
//    int left = 0;
//    int right = n - 1;

//    while (left <= right)
//    {
//      int mid = (left + right) / 2;
//      if (A[mid] == k)
//      {
//        return true;
//      }
//      else if (A[mid] < k)
//      {
//        left = mid + 1;
//      }
//      else
//      {
//        right = mid - 1;
//      }
//    }
//    return check;
//  }

//  //STEP: 2 lower_bound
//  private static int LowerBound(int[] A, int n, int k)
//  {
//    int left = 0;
//    int right = n;

//    while (left < right)
//    {
//      int mid = (left + right) / 2;
//      if (A[mid] < k)
//      {
//        left = mid + 1;
//      }
//      else
//      {
//        right = mid;
//      }
//    }
//    return right;
//  }

//  //STEP: 3 upper_bound
//  private static int UpperBound(int[] A, int n, int k)
//  {
//    int left = 0;
//    int right = n;

//    while (left < right)
//    {
//      int mid = (left + right) / 2;
//      if (A[mid] <= k)
//      {
//        left = mid + 1;
//      }
//      else
//      {
//        right = mid;
//      }
//    }
//    return right;
//  }

//  /********** 長い長い数列 **************/
//  //STEP: 1 パイプを切り出そう
//  private static double PipeMax(int[] A, int n, int k)
//  {
//    double left = 0, right = A.Max();

//    while ((right - left) >= Math.Pow(10, -6))
//    {
//      double mid = (left + right) * 0.5;
//      int num = 0;
//      foreach (int ai in A)
//      {
//        num += (int)Math.Floor(ai / mid);
//      }
//      if (num < k)
//      {
//        right = mid;
//      }
//      else
//      {
//        left = mid;
//      }
//    }
//    return right;
//  }

//  //STEP: 2 効率よく盗もう
//  private static double ValueMax(int[] W, int[] V, int n, int k)
//  {
//    double left = 0, right = 5000;

//    while ((right - left) >= Math.Pow(10, -6))
//    {
//      double mid = (left + right) * 0.5;
//      double[] doubles = new double[n];
//      for (int i = 0; i < n; i++)
//      {
//        doubles[i] = V[i] - mid * W[i];
//      }
//      double sum = doubles.OrderByDescending(x => x).Take(k).Sum();
//      if (sum > 0)
//      {
//        left = mid;
//      }
//      else
//      {
//        right = mid;
//      }
//    }
//    return right;
//  }

//  //STEP: 3 太巻きを分けよう (おなかペコペコ)
//  private static int HungryMax(int[] A, int L, int n, int k)
//  {
//    int left = 0, right = L;
//    A = A.Append(L).ToArray();

//    while (left < right - 1)
//    {
//      int mid = (left + right) / 2;
//      int bound = 0;
//      int num = 0;
//      for (int i = 0; i <= k; i++)
//      {
//        if (A[i] - bound >= mid)
//        {
//          num++;
//          bound = A[i];
//        }
//      }

//      if (num < n)
//      {
//        right = mid;
//      }
//      else
//      {
//        left = mid;
//      }
//    }
//    return left;
//  }

//  //STEP: 4 太巻きを分けよう(おなかいっぱい)
//  private static int HungryMin(int[] A, int L, int n, int k)
//  {
//    int left = 0, right = L - (n - 1);
//    A = A.Prepend(0).Append(L).ToArray();
//    for (int i = 1; i < A.Length; i++)
//    {
//      left = Math.Max(left, A[i] - A[i - 1]);
//    }
//    left--;

//    while (left < right - 1)
//    {
//      int mid = (left + right) / 2;
//      int lastIndex = 0;
//      int index = 0;
//      int num = 0;
//      while (index != A.Length - 1)
//      {
//        while (index + 1 < A.Length && A[index + 1] - A[lastIndex] <= mid)
//        {
//          index++;
//        }
//        num++;
//        lastIndex = index;
//      }

//      if (num > n)
//      {
//        left = mid;
//      }
//      else
//      {
//        right = mid;
//      }
//    }
//    return right;
//  }

//  //FINAL問題 長い長い数列
//  private static int LongLongAB(int[] A, int n, int[] B, int m, int k)
//  {
//    int left = -1, right = 200000000;

//    while (left < right - 1)
//    {
//      int mid = (left + right) / 2;
//      long num = 0;
//      for (int i = 0; i < n; i++)
//      {
//        num += UpperBound(B, m, A[i] + mid) - LowerBound(B, m, A[i] - mid);
//        if (num >= k) { break; }
//      }
//      if (num < k)
//      {
//        left = mid;
//      }
//      else
//      {
//        right = mid;
//      }
//    }
//    return right;
//  }
//}
