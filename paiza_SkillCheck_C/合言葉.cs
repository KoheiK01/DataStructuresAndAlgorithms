//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    Dictionary<char, int> a = new Dictionary<char, int>();
//    Dictionary<char, int> b = new Dictionary<char, int>();

//    string s = Console.ReadLine();
//    for (int i = 0; i < s.Length; i++)
//    {
//      if (a.ContainsKey(s[i]))
//      {
//        a[s[i]]++;
//      }
//      else
//      {
//        a.Add(s[i], 1);
//      }
//    }

//    string t = Console.ReadLine();
//    for (int i = 0; i < t.Length; i++)
//    {
//      if (b.ContainsKey(t[i]))
//      {
//        b[t[i]]++;
//      }
//      else
//      {
//        b.Add(t[i], 1);
//      }
//    }

//    string ans = "YES";

//    if (s == t)
//    {
//      ans = "NO";
//    }
//    else
//    {
//      foreach (var item in a)
//      {
//        if (b.ContainsKey(item.Key))
//        {
//          if (b[item.Key] != item.Value)
//          {
//            ans = "NO";
//            break;
//          }
//        }
//        else
//        {
//          ans = "NO";
//          break;
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}