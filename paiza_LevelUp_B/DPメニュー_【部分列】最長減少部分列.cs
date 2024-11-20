//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【連続列】最長減少連続部分列 **********/
//    //STEP: 1 最長部分増加列
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = Enumerable.Repeat(1, n).ToArray();
//    //for (int i = 1; i < n; i++)
//    //{
//    //  for (int j = 0; j < i; j++)
//    //  {
//    //    if (A[j] < A[i])
//    //    {
//    //      dp[i] = Math.Max(dp[i], dp[j] + 1);
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(dp.Max());

//    //FINAL問題 【部分列】最長減少部分列
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = Enumerable.Repeat(1, n).ToArray();
//    //for (int i = 1; i < n; i++)
//    //{
//    //  for (int j = 0; j < i; j++)
//    //  {
//    //    if (A[j] > A[i])
//    //    {
//    //      dp[i] = Math.Max(dp[i], dp[j] + 1);
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(dp.Max());
//  }
//}