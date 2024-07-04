//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int x = int.Parse(words[1]);
//    int y = int.Parse(words[2]);

//    List<int> prices = new List<int>();

//    for (int i = 1; i <= n; i++)
//    {
//      int p = int.Parse(Console.ReadLine());
//      prices.Add(p);
//    }
//    prices = prices.OrderBy(g => g).ToList();

//    int money = 0;
//    if (n >= x)
//    {
//      for (int i = y + 1; i <= n; i++)
//      {
//        money += prices[i - 1];
//      }
//    }
//    else
//    {
//      for (int i = 1; i <= n; i++)
//      {
//        money += prices[i - 1];
//      }
//    }

//    Console.WriteLine(money);
//  }
//}