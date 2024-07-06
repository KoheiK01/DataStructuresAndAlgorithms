//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    var words = Console.ReadLine().Split(' ');

//    bool to10x = false;
//    bool to0 = false;
//    List<int> cards = new List<int>();
//    for (int i = 0; i < n; i++)
//    {
//      if (words[i] == "x10")
//      {
//        to10x = true;
//      }
//      else if (words[i] == "0")
//      {
//        to0 = true;
//      }
//      else
//      {
//        cards.Add(int.Parse(words[i]));
//      }
//    }

//    cards = cards.OrderByDescending(x => x).ToList();
//    if (to0)
//    {
//      cards[0] = 0;
//    }
//    int ans = cards.Sum(x => x);
//    if (to10x)
//    {
//      ans *= 10;
//    }
//    Console.WriteLine(ans);
//  }
//}
