//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());

//    int preDay = int.Parse(Console.ReadLine());
//    int start = preDay;
//    int end = preDay;
//    int max = 1;
//    int count = 1;

//    for (int i = 1; i < n; i++)
//    {
//      int day = int.Parse(Console.ReadLine());
//      if (preDay == day - 1)
//      {
//        count++;
//        if (count > max)
//        {
//          start = day - count + 1;
//          end = day;
//          max = count;
//        }
//      }
//      else
//      {
//        count = 1;
//      }
//      preDay = day;
//    }

//    Console.WriteLine(start + " " + end);
//  }
//}