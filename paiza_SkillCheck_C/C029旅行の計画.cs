//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int m = int.Parse(words[0]);
//    int n = int.Parse(words[1]);

//    int inputStartDay = 0;
//    int[] forecasts = new int[m];
//    for (int i = 0; i < m; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int parcent = int.Parse(words[1]);
//      forecasts[i] = parcent;
//      if (i == 0)
//      {
//        inputStartDay = int.Parse(words[0]);
//      }
//    }

//    int startDay = 0;
//    int minSumParcent = int.MaxValue;
//    int sumParcent = 0;
//    for (int i = 0; i < m; i++)
//    {
//      sumParcent += forecasts[i];

//      if (i + 1 >= n)
//      {
//        if (sumParcent < minSumParcent)
//        {
//          minSumParcent = sumParcent;
//          startDay = i + 1 - n + inputStartDay;
//        }
//        sumParcent -= forecasts[i + 1 - n];
//      }
//    }
//    Console.WriteLine(startDay + " " + (startDay + n - 1));
//  }
//}