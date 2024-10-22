//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int n = int.Parse(Console.ReadLine());
//    List<Medal> list = new List<Medal>();
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int g = int.Parse(words[0]);
//      int s = int.Parse(words[1]);
//      int b = int.Parse(words[2]);

//      list.Add(new Medal() { Gold = g, Silver = s, Bronze = b });
//    }
//    list = list
//      .OrderByDescending(x => x.Gold)
//      .ThenByDescending(s => s.Silver)
//      .ThenByDescending(s => s.Bronze)
//      .ToList();

//    list.ForEach(x => Console.WriteLine(x.Gold + " " + x.Silver + " " + x.Bronze));

//  }
//}

//class Medal
//{
//  public int Gold;
//  public int Silver;
//  public int Bronze;
//}