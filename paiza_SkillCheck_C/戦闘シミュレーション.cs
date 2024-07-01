//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int n = int.Parse(words[0]);
//    int level = int.Parse(words[1]);
//    for (int i = 0; i < n; i++)
//    {
//      int x = int.Parse(Console.ReadLine());
//      if (level < x)
//      {
//        level /= 2;
//      }
//      else if (level > x)
//      {
//        level += x / 2;
//      }
//    }
//    Console.WriteLine(level);
//  }
//}