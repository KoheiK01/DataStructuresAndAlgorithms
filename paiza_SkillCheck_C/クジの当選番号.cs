//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var oks = Console.ReadLine().Split(' ');

//    int n = int.Parse(Console.ReadLine());
//    for (int i = 0; i < n; i++)
//    {
//      int ans = 0;
//      var nows = Console.ReadLine().Split(' ');
//      for (int j = 0; j < 6; j++)
//      {
//        if (oks.Contains(nows[j]))
//        {
//          ans++;
//        }
//      }
//      Console.WriteLine(ans);
//    }
//  }
//}