//using System;
//using System.Collections.Generic;
//using System.Security.Cryptography;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int hate = int.Parse(Console.ReadLine());
//    int room = int.Parse(Console.ReadLine());

//    List<string> list = new List<string>();
//    for (int i = 0; i < room; i++)
//    {
//      string name = Console.ReadLine();
//      if (!name.Contains(hate.ToString()))
//      {
//        list.Add(name);
//      }
//    }
//    string ans;
//    if (list.Count == 0)
//    {
//      ans = "none";
//    }
//    else
//    {
//      ans = string.Join("\n", list);
//    }
//    Console.WriteLine(ans);

//  }
//}