//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int[] scores = new int[n];
//    int[] ranks = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//      int ai = int.Parse(Console.ReadLine());
//      scores[i] = ai;
//      for (int j = 0; j < i; j++)
//      {
//        if (scores[i] > scores[j])
//        {
//          ranks[j]++;
//        }
//        else if (scores[i] < scores[j])
//        {
//          ranks[i]++;
//        }
//      }
//    }

//    foreach (var item in ranks)
//    {
//      Console.WriteLine(item + 1);
//    }
//  }
//}