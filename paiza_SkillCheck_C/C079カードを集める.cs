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
//    List<int> list = new List<int>();

//    string ans = "unlucky";
//    int kind = 0;
//    for (int i = 0; i < n; i++)
//    {
//      int c = int.Parse(Console.ReadLine());
//      if (!list.Contains(c))
//      {
//        kind++;
//        list.Add(c);
//        if (kind == m)
//        {
//          ans = (i + 1).ToString();
//          break;
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}