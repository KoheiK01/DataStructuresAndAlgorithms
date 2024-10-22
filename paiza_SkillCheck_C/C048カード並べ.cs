//using System;
//using System.Collections.Generic;
//using System.IO.Pipes;
//using System.Linq;
//using System.Runtime.ExceptionServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int a = int.Parse(words[0]);
//    int b = int.Parse(words[1]);
//    int c = int.Parse(words[2]);
//    int d = int.Parse(words[3]);
//    int[] cards = new int[4] { a, b, c, d };
//    int ans = 0;

//    for (int i = 1; i >= 0; i--)
//    {
//      for (int j = 3; j >= 1; j--)
//      {
//        int left = cards[0] * (int)Math.Pow(10, i);
//        left += cards[j] * (int)Math.Pow(10, 1 - i);
//        for (int k = 3; k >= 1; k--)
//        {
//          if (k == j) { continue; }
//          for (int l = 3; l >= 1; l--)
//          {
//            if (l == j || k == l) { continue; }
//            int right = cards[k] * (int)Math.Pow(10, i);
//            right += cards[l] * (int)Math.Pow(10, 1 - i);
//            ans = Math.Max(ans, left + right);
//          }
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}