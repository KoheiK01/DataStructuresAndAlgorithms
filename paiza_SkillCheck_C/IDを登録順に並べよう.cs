//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    Dictionary<string, int> _keyValuePairs = new Dictionary<string, int>();

//    for (int i = 0; i < n; i++)
//    {
//      string s = Console.ReadLine();
//      _keyValuePairs.Add(s, int.Parse(Regex.Replace(s, @"[^0-9]", "")));
//    }
//    _keyValuePairs = _keyValuePairs
//      .OrderBy(kv => kv.Value)
//      .ToDictionary(kv => kv.Key, kv => kv.Value);

//    foreach (var item in _keyValuePairs)
//    {
//      Console.WriteLine(item.Key);
//    }
//  }
//}