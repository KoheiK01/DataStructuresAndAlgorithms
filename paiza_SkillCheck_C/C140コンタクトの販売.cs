//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int[] stocks = new int[n];

//    for (int i = 0; i < n; i++)
//    {
//      stocks[i] = int.Parse(Console.ReadLine());
//    }

//    int ans = 0;
//    int m = int.Parse(Console.ReadLine());
//    for (int i = 0; i < m; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int r = int.Parse(words[0]);
//      int l = int.Parse(words[1]);
//      if (r == l)
//      {
//        if (stocks[r - 1] >= 2)
//        {
//          ans++;
//          stocks[r - 1] -= 2;
//        }
//      }
//      else
//      {
//        if (stocks[r - 1] >= 1 && stocks[l - 1] >= 1)
//        {
//          ans++;
//          stocks[r - 1]--;
//          stocks[l - 1]--;
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}