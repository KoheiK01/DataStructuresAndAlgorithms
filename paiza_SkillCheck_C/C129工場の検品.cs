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
//    Dictionary<int, int> a = new Dictionary<int, int>();
//    Dictionary<int, int> b = new Dictionary<int, int>();

//    string ans = "Yes";

//    for (int i = 0; i < m; i++)
//    {
//      int susi = int.Parse(Console.ReadLine());
//      if (a.ContainsKey(susi))
//      {
//        a[susi]++;
//      }
//      else
//      {
//        a.Add(susi, 1);
//      }
//    }
//    for (int i = 0; i < m; i++)
//    {
//      int susi = int.Parse(Console.ReadLine());
//      if (b.ContainsKey(susi))
//      {
//        b[susi]++;
//      }
//      else
//      {
//        b.Add(susi, 1);
//      }
//    }
//    foreach (var item in a)
//    {
//      if (b.ContainsKey(item.Key))
//      {
//        if (b[item.Key] != item.Value)
//        {
//          ans = "No";
//          break;
//        }
//      }
//      else
//      {
//        ans = "No";
//        break;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}