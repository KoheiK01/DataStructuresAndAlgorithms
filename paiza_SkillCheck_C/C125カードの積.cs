//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int N = int.Parse(Console.ReadLine());

//    int origin = 1;
//    int[] cards = new int[N];
//    var words = Console.ReadLine().Split(' ');
//    for (int i = 0; i < N; i++)
//    {
//      int card = int.Parse(words[i]);
//      cards[i] = card;
//      origin *= card;
//    }

//    int max = int.MinValue;
//    for (int i = 0; i < N; i++)
//    {
//      for (int j = 0; j < N; j++)
//      {
//        if (i == j) continue;
//        int seki = 1;
//        for (int k = 0; k < N; k++)
//        {
//          if (k == i)
//          {
//            seki *= cards[k] + 1;
//          }
//          else if (k == j)
//          {
//            seki *= cards[k] - 1;
//          }
//          else
//          {
//            seki *= cards[k];
//          }
//        }
//        max = Math.Max(max, seki);
//      }
//    }
//    Console.WriteLine(max);
//  }
//}
