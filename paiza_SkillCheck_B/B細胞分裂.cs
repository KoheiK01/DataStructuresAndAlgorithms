//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());
//    bool[] isWork = new bool[100001];
//    int max = 0;
//    int count = 0;

//    for (int i = 0; i < N; i++)
//    {
//      string[] words = Console.ReadLine().Split();
//      int start = int.Parse(words[0]);
//      int end = int.Parse(words[1]);

//      for (int date = start; date <= end; date++)
//        isWork[date] = true;
//    }

//    for (int date = 1; date < isWork.Length; date++)
//    {
//      if (isWork[date])
//        count++;
//      else
//      {
//        max = Math.Max(max, count);
//        count = 0;
//      }
//    }

//    max = Math.Max(max, count);
//    Console.WriteLine(max);
//  }
//}