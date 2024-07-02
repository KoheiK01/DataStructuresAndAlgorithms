//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int point = 0;

//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      if (words[0].Contains("5"))
//      {
//        point += int.Parse(words[1]) * 5 / 100;
//      }
//      else if (words[0].Contains("3"))
//      {
//        point += int.Parse(words[1]) * 3 / 100;
//      }
//      else
//      {
//        point += int.Parse(words[1]) / 100;
//      }
//    }
//    Console.WriteLine(point);
//  }
//}