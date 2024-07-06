//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int s = int.Parse(words[0]);
//    int a = int.Parse(words[1]);
//    int b = int.Parse(words[2]);

//    string win = "A";
//    int which = 0;
//    while (true)
//    {
//      if (which % 2 == 0)
//      {
//        if (a >= s + 10)
//        {
//          s += 10;
//          win = "A";
//        }
//        else
//        {
//          break;
//        }
//      }
//      else
//      {
//        if (b >= s + 1000)
//        {
//          s += 1000;
//          win = "B";
//        }
//        else
//        {
//          break;
//        }
//      }
//      which++;
//    }

//    Console.WriteLine(win + " " + s);
//  }
//}