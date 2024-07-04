//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int total = 0;
//    int n = int.Parse(Console.ReadLine());

//    int one = 100000;
//    int two = 750000;
//    int thr = 1500000;
//    for (int i = 0; i < n; i++)
//    {
//      int x = int.Parse(Console.ReadLine());
//      if (x > one)
//      {
//        if (x > two)
//        {
//          total += (two - one) * 10 / 100;
//          if (x > thr)
//          {
//            total += (thr - two) * 20 / 100;
//            total += (x - thr) * 40 / 100;
//          }
//          else
//          {
//            total += (x - two) * 20 / 100;
//          }
//        }
//        else
//        {
//          total += (x - one) * 10 / 100;
//        }
//      }
//    }
//    Console.WriteLine(total);
//  }
//}