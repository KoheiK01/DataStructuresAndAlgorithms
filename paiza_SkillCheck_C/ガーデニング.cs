//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int N = int.Parse(Console.ReadLine());
//    int[] flowers = new int[61];

//    for (int i = 0; i < N; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int ai = int.Parse(words[0]);
//      int bi = int.Parse(words[1]);
//      flowers[ai + bi]++;
//    }

//    int maxNum = 0;
//    int date = 0;
//    for (int i = 1; i <= 60; i++)
//    {
//      if (flowers[i] > maxNum)
//      {
//        maxNum = flowers[i];
//        date = i;
//      }
//    }

//    Console.WriteLine(date);
//  }
//}
