//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    string t = words[1];
//    char[] _chars = words[2].ToCharArray();

//    int ans = 0;
//    for (int i = 0; i < n; i++)
//    {
//      if (string.Join("", _chars) == t)
//      {
//        ans = i;
//        break;
//      }
//      else
//      {
//        char temp = _chars[0];
//        for (int j = 0; j < n - 1; j++)
//        {
//          _chars[j] = _chars[j + 1];
//        }
//        _chars[n - 1] = temp;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}