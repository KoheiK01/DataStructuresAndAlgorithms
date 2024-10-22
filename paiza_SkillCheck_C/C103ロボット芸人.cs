//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int m = int.Parse(words[1]);
//    List<string>[] sim = new List<string>[n + 1];
//    for (int i = 1; i <= n; i++)
//    {
//      sim[i] = new List<string>();
//    }

//    for (int i = 0; i < m; i++)
//    {
//      words = Console.ReadLine().Split();
//      int a = int.Parse(words[0]);
//      for (int time = a; time <= n; time += a)
//      {
//        sim[time].Add(words[1]);
//      }
//    }
//    for (int time = 1; time <= n; time++)
//    {
//      if (sim[time].Count == 0)
//      {
//        Console.WriteLine(time);
//      }
//      else
//      {
//        Console.WriteLine(string.Join(" ", sim[time]));
//      }
//    }
//  }
//}