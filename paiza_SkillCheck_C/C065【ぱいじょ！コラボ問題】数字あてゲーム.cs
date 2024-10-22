//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());

//    int max = 100;
//    int min = 1;
//    List<int> divisors = new List<int>() { 1 };

//    for (int i = 0; i < N; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string o = words[0];
//      int x = int.Parse(words[1]);

//      if (o == ">")
//      {
//        min = Math.Max(min, x + 1);
//      }
//      else if (o == "<")
//      {
//        max = Math.Min(max, x - 1);
//      }
//      else if (o == "/")
//      {
//        divisors.Add(x);
//      }
//    }

//    for (int i = min; i <= max; i++)
//    {
//      bool judge = true;
//      for (int j = 0; j < divisors.Count; j++)
//      {
//        if (i % divisors[j] != 0)
//        {
//          judge = false;
//          break;
//        }
//      }
//      if (judge)
//      {
//        Console.WriteLine(i);
//        return;
//      }
//    }
//  }
//}