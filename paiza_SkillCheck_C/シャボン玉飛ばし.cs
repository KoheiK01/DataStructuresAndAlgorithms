//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int t = int.Parse(words[0]);
//    int x = int.Parse(words[1]);
//    int y = int.Parse(words[2]);
//    int xMax = x;

//    for (int i = 0; i < t; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int a = int.Parse(words[0]);
//      int b = int.Parse(words[1]);
//      x += a;
//      xMax = Math.Max(x, xMax);
//      y += b;
//      if (y <= 0)
//      {
//        break;
//      }
//    }
//    Console.WriteLine(xMax);
//  }
//}