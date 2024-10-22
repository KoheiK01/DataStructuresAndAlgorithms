//using System;
//using System.Linq.Expressions;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int k = int.Parse(words[1]);
//    int haiten = 100 / k;
//    var scores = new int[n];

//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int d = int.Parse(words[0]);
//      int a = int.Parse(words[1]);
//      if (d <= 0)
//      {
//        scores[i] = a * haiten;
//      }
//      else if (d <= 9)
//      {
//        scores[i] = a * haiten * 8 / 10;
//      }
//      else
//      {
//        scores[i] = 0;
//      }
//    }
//    for (int i = 0; i < n; i++)
//    {
//      if (scores[i] >= 80)
//      {
//        Console.WriteLine("A");
//      }
//      else if (scores[i] >= 70)
//      {
//        Console.WriteLine("B");
//      }
//      else if (scores[i] >= 60)
//      {
//        Console.WriteLine("C");
//      }
//      else
//      {
//        Console.WriteLine("D");
//      }
//    }
//  }
//}