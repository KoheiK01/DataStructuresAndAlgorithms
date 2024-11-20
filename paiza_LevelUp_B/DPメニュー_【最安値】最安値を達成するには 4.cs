//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【階段の上り方】階段の上り方 3 **********/
//    //STEP: 1 最安値を達成するには 1
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], a = firstLine[1], b = firstLine[2];
//    //int[] A = new int[n + 1];
//    //A[0] = 0; A[1] = a;
//    //for (int i = 2; i <= n; i++)
//    //{
//    //  A[i] = Math.Min(A[i - 1] + a, A[i - 2] + b);
//    //}
//    //Console.WriteLine(A[n]);

//    //STEP: 2 最安値を達成するには 2
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], a = firstLine[1], b = firstLine[2];
//    //int[] A = Enumerable.Repeat(10000000, n + 5).ToArray();
//    //A[0] = 0;
//    //for (int i = 2; i < n + 5; i++)
//    //{
//    //  A[i] = Math.Min(A[i], A[i - 2] + a);
//    //  if (i >= 5)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - 5] + b);
//    //  }
//    //}
//    //Console.WriteLine(A.Skip(n).Take(5).Min());

//    //STEP: 3 最安値を達成するには 3
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1], a = firstLine[2], y = firstLine[3], b = firstLine[4];
//    //int[] A = Enumerable.Repeat(10000000, n + y).ToArray();
//    //A[0] = 0;
//    //for (int i = 2; i < n + y; i++)
//    //{
//    //  if (i >= x)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - x] + a);
//    //  }
//    //  if (i >= y)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - y] + b);
//    //  }
//    //}
//    //Console.WriteLine(A.Skip(n).Take(y).Min());

//    //FINAL問題 【最安値】最安値を達成するには 4
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1], a = firstLine[2], y = firstLine[3], b = firstLine[4], z = firstLine[5], c = firstLine[6];
//    //int[] A = Enumerable.Repeat(10000000, n + z).ToArray();
//    //A[0] = 0;
//    //for (int i = 2; i < n + z; i++)
//    //{
//    //  if (i >= x)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - x] + a);
//    //  }
//    //  if (i >= y)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - y] + b);
//    //  }
//    //  if (i >= z)
//    //  {
//    //    A[i] = Math.Min(A[i], A[i - z] + c);
//    //  }
//    //}
//    //Console.WriteLine(A.Skip(n).Take(z).Min());
//  }
//}
