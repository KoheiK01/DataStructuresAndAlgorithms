//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    List<int> scores = new List<int>();

//    int n = int.Parse(Console.ReadLine());
//    var words = Console.ReadLine().Split(' ');
//    for (int i = 0; i < n; i++)
//    {
//      int score = int.Parse(words[i]);
//      scores.Add(score);
//    }

//    for (int i = 0; i < n; i++)
//    {
//      int upper = scores.Count(score => score > scores[i]);

//      if (upper == 0)
//      {
//        Console.WriteLine("G");
//      }
//      else if (upper == 1)
//      {
//        Console.WriteLine("S");
//      }
//      else if (upper == 2)
//      {
//        Console.WriteLine("B");
//      }
//      else
//      {
//        Console.WriteLine("N");
//      }
//    }
//  }
//}