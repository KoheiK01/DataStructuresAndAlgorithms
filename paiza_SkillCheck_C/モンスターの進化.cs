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
//    int atk = int.Parse(words[0]);
//    int def = int.Parse(words[1]);
//    int agi = int.Parse(words[2]);

//    List<string> ans = new List<string>();

//    int n = int.Parse(Console.ReadLine());
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int minatk = int.Parse(words[1]);
//      int maxatk = int.Parse(words[2]);
//      if (minatk <= atk && atk <= maxatk)
//      {
//        int mindef = int.Parse(words[3]);
//        int maxdef = int.Parse(words[4]);
//        if (mindef <= def && def <= maxdef)
//        {
//          int minagi = int.Parse(words[5]);
//          int maxagi = int.Parse(words[6]);
//          if (minagi <= agi && agi <= maxagi)
//          {
//            ans.Add(words[0]);
//          }
//        }
//      }
//    }
//    if (ans.Count == 0) ans.Add("no evolution");
//    Console.WriteLine(string.Join("\n", ans));
//  }
//}