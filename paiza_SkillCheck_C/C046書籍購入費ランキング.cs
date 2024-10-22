//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int N = int.Parse(Console.ReadLine());

//    Dictionary<string, int> moneys = new Dictionary<string, int>();
//    var words = Console.ReadLine().Split(' ');
//    for (int i = 0; i < N; i++)
//    {
//      moneys.Add(words[i], 0);
//    }

//    int M = int.Parse(Console.ReadLine());
//    for (int i = 0; i < M; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      string name = words[0];
//      int money = int.Parse(words[1]);
//      moneys[name] += money;
//    }
//    moneys = moneys
//      .OrderByDescending(x => x.Value)
//      .ToDictionary(x => x.Key, x => x.Value);

//    foreach (var item in moneys)
//    {
//      Console.WriteLine(item.Key);
//    }
//  }
//}
