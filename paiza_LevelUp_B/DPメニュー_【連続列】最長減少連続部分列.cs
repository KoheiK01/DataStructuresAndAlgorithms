//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【連続列】最長減少連続部分列 **********/
//    //STEP: 1 最長増加連続部分列
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = new int[n];
//    //dp[0] = 1;
//    //for (int i = 1; i < n; i++)
//    //{
//    //  if (A[i - 1] <= A[i]) { dp[i] = dp[i - 1] + 1; }
//    //  else { dp[i] = 1; }
//    //}
//    //Console.WriteLine(dp.Max());

//    //FINAL問題 【連続列】最長減少連続部分列
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = new int[n];
//    //dp[0] = 1;
//    //for (int i = 1; i < n; i++)
//    //{
//    //  if (A[i - 1] >= A[i]) { dp[i] = dp[i - 1] + 1; }
//    //  else { dp[i] = 1; }
//    //}
//    //Console.WriteLine(dp.Max());
//  }
//}