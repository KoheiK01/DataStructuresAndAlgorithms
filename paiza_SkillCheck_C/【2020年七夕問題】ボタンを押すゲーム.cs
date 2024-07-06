//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int maxy = int.Parse(words[1]);

//    int m = int.Parse(Console.ReadLine());
//    words = Console.ReadLine().Split(' ');

//    int score = 0;
//    int y = 0;
//    for (int i = 0; i < m; i++)
//    {
//      int input = int.Parse(words[i]);
//      if (input == i % n + 1)
//      {
//        score += 1000;
//      }
//      else
//      {
//        y++;
//        if (y == maxy)
//        {
//          score = -1; break;
//        }
//      }
//    }
//    Console.WriteLine(score);
//  }
//}