//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int x = int.Parse(words[0]);
//    int y = int.Parse(words[1]);
//    int z = int.Parse(words[2]);

//    int[] moneys = new int[24];
//    for (int i = 0; i < 24; i++)
//    {
//      if (i < 9)
//      {
//        moneys[i] = z;
//      }
//      else if (i < 17)
//      {
//        moneys[i] = x;
//      }
//      else if (i < 22)
//      {
//        moneys[i] = y;
//      }
//      else
//      {
//        moneys[i] = z;
//      }
//    }

//    int n = int.Parse(Console.ReadLine());
//    int sum = 0;
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int s = int.Parse(words[0]);
//      int t = int.Parse(words[1]);
//      for (int j = s; j < t; j++)
//      {
//        sum += moneys[j];
//      }
//    }
//    Console.WriteLine(sum.ToString());
//  }
//}
