//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int q = int.Parse(Console.ReadLine());
//    for (int i = 0; i < q; i++)
//    {
//      List<int> list = new List<int>();
//      int n = int.Parse(Console.ReadLine());
//      for (int j = 1; j < n; j++)
//      {
//        if (n % j == 0)
//        {
//          list.Add(j);
//        }
//      }
//      if (list.Sum() == n)
//      {
//        Console.WriteLine("perfect");
//      }
//      else if (Math.Abs(list.Sum() - n) == 1)
//      {
//        Console.WriteLine("nearly");
//      }
//      else
//      {
//        Console.WriteLine("neither");
//      }
//    }
//  }
//}