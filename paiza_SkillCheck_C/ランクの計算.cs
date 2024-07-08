//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int k = int.Parse(words[1]);

//    int[,] results = new int[3, n + 1];
//    for (int i = 0; i < 3; i++)
//    {
//      for (int j = 1; j <= n; j++)
//      {
//        results[i, j] = int.Parse(Console.ReadLine());
//      }
//    }

//    double minRank = int.MaxValue;
//    int minHorse = 0;
//    for (int i = 0; i < 3; i++)
//    {
//      int minSumRank = int.MaxValue;
//      int sumRank = 0;
//      for (int j = 1; j <= n; j++)
//      {
//        sumRank += results[i, j];

//        if (j >= k)
//        {
//          minSumRank = Math.Min(minSumRank, sumRank);
//          sumRank -= results[i, j - k + 1];
//        }
//      }

//      if (minSumRank < minRank)
//      {
//        minRank = minSumRank;
//        minHorse = i + 1;
//      }
//    }
//    Console.WriteLine(minHorse);
//  }
//}