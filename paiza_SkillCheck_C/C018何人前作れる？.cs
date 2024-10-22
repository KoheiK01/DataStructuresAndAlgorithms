//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    Dictionary<string, int> recipes = new Dictionary<string, int>();
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string a = words[0];
//      int b = int.Parse(words[1]);
//      recipes.Add(a, b);
//    }

//    int m = int.Parse(Console.ReadLine());
//    Dictionary<string, int> haves = new Dictionary<string, int>();
//    for (int i = 0; i < m; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string c = words[0];
//      int d = int.Parse(words[1]);
//      haves.Add(c, d);
//    }

//    int max = int.MaxValue;
//    foreach (var item in recipes)
//    {
//      if (haves.ContainsKey(item.Key))
//      {
//        max = Math.Min(max, haves[item.Key] / item.Value);
//      }
//      else
//      {
//        max = 0;
//        break;
//      }
//    }

//    Console.WriteLine(max);
//  }
//}