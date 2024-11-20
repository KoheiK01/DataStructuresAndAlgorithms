//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【部分和】部分和問題 4 **********/
//    //STEP: 1 部分和問題 1
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1];
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //bool[] dp = Enumerable.Repeat(false, x + 1).ToArray();
//    //dp[0] = true;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  for (int j = x; j >= A[i]; j--)
//    //  {
//    //    dp[j] = dp[j] || dp[j - A[i]];
//    //  }
//    //}
//    //Console.WriteLine(dp[x] ? "yes" : "no");

//    //STEP: 2 部分和問題 2
//    //const int MOD = 1000000007;
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1];
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = new int[x + 1];
//    //dp[0] = 1;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  for (int j = x; j >= A[i]; j--)
//    //  {
//    //    dp[j] += dp[j - A[i]];
//    //    dp[j] %= MOD;
//    //  }
//    //}
//    //Console.WriteLine(dp[x]);

//    //STEP: 3 部分和問題 3
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1];
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] dp = Enumerable.Repeat(1000, x + 1).ToArray();
//    //dp[0] = 0;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  for (int j = x; j >= A[i]; j--)
//    //  {
//    //    dp[j] = Math.Min(dp[j], dp[j - A[i]] + 1);
//    //  }
//    //}
//    //Console.WriteLine(dp[x] == 1000 ? -1 : dp[x]);

//    //FINAL問題 【部分和】部分和問題 4
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = firstLine[0], x = firstLine[1];
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //bool[] dp = Enumerable.Repeat(false, x + 1).ToArray();
//    //dp[0] = true;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  for (int j = A[i]; j <= x; j++)
//    //  {
//    //    dp[j] = dp[j] || dp[j - A[i]];
//    //  }
//    //}
//    //Console.WriteLine(dp[x] ? "yes" : "no");
//  }
//}