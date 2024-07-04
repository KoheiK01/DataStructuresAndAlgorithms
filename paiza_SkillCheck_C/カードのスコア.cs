//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    var words = Console.ReadLine().Split(' ');
//    List<int> c = new List<int>();
//    for (int i = 0; i < n; i++)
//    {
//      c.Add(int.Parse(words[i]));
//    }
//    c = c.OrderBy(x => x).ToList();
//    int sum = 0;

//    for (int i = 0; i < c.Count - 1; i++)
//    {
//      if (c[i] == c[i + 1] - 1) continue;
//      sum += c[i];
//    }
//    sum += c.Last();
//    Console.WriteLine(sum);
//  }
//}