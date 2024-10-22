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

//    int ans = 0;
//    for (int i = 1; i < n; i++)
//    {
//      for (int j = 1; j < m; j++)
//      {
//        double c = Math.Sqrt(i * i + j * j);
//        if (c == (int)c)
//        {
//          ans++;
//        }
//      }
//    }

//    Console.WriteLine(ans);
//  }
//}