//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int m = int.Parse(words[1]);
//    List<int> oks = new List<int>();
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split();
//      int a = int.Parse(words[0]);
//      int b = int.Parse(words[1]);
//      int score = Math.Max(a - 5 * b, 0);
//      if (score >= m)
//      {
//        oks.Add(i + 1);
//      }
//    }
//    for (int i = 0; i < oks.Count; i++)
//    {
//      Console.WriteLine(oks[i]);
//    }
//  }
//}