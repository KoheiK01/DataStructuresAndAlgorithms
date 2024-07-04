//using System;
//using System.Linq;
//using System.Runtime.ExceptionServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int ans = 0;
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split();
//      int e = int.Parse(words[1]);
//      int m = int.Parse(words[2]);
//      int s = int.Parse(words[3]);
//      int j = int.Parse(words[4]);
//      int g = int.Parse(words[5]);

//      int all = e + m + s + j + g;
//      if (all >= 350)
//      {
//        if (words[0] == "s")
//        {
//          if (m + s >= 160)
//          {
//            ans++;
//          }
//        }
//        else
//        {
//          if (j + g >= 160)
//          {
//            ans++;
//          }
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}