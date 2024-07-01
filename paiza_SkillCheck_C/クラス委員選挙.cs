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
//    Dictionary<string, int> dic = new Dictionary<string, int>();

//    for (int i = 0; i < n; i++)
//    {
//      string name = Console.ReadLine();
//      if (dic.ContainsKey(name))
//      {
//        dic[name]++;
//      }
//      else
//      {
//        dic[name] = 1;
//      }
//    }

//    string ans = dic.OrderByDescending(x => x.Value).First().Key;
//    Console.WriteLine(ans);
//  }
//}