//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'strNum チャレンジ！！
//    int n = int.Parse(Console.ReadLine());

//    Dictionary<string, int> method1 = new Dictionary<string, int>();
//    Dictionary<string, int> method2 = new Dictionary<string, int>();

//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string name = words[0];
//      int value = int.Parse(words[1]);
//      if (method1.ContainsKey(name))
//      {
//        method1[name]++;
//        method2[name] += value;
//      }
//      else
//      {
//        method1[name] = 1;
//        method2[name] = value;
//      }
//    }
//    string ans1 = method1.OrderByDescending(x => x.Value).First().Key;
//    string ans2 = method2.OrderByDescending(x => x.Value).First().Key;
//    Console.WriteLine(ans1);
//    Console.WriteLine(ans2);
//  }
//}