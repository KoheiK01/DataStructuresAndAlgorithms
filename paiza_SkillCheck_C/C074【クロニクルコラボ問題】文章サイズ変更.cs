//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int h = int.Parse(words[0]);
//    int w = int.Parse(words[1]);
//    int x = int.Parse(words[2]);
//    List<char> list = new List<char>();

//    for (int i = 0; i < h; i++)
//    {
//      string s = Console.ReadLine();
//      for (int j = 0; j < s.Length; j++)
//      {
//        list.Add(s[j]);
//      }
//    }

//    for (int i = 0; i < list.Count; i++)
//    {
//      Console.Write(list[i]);
//      if ((i + 1) % x == 0)
//      {
//        Console.WriteLine();
//      }
//    }
//  }
//}