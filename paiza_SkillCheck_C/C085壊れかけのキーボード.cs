//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string alphabets = "abcdefghijklmnopqrstuvwxyz";
//    var words = Console.ReadLine().Split(' ');
//    Dictionary<char, int> remain = new Dictionary<char, int>();
//    for (int i = 0; i < 26; i++)
//    {
//      remain.Add(alphabets[i], int.Parse(words[i]));
//    }

//    string s = Console.ReadLine();
//    for (int i = 0; i < s.Length; i++)
//    {
//      if (remain[s[i]] >= 1)
//      {
//        Console.Write(s[i]);
//        remain[s[i]]--;
//      }
//    }
//  }
//}