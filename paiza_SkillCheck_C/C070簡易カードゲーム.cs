//using System;
//using System.Collections.Specialized;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());

//    for (int i = 0; i < n; i++)
//    {
//      string s = Console.ReadLine();
//      bool twoPare = false;
//      int count = 1;
//      int maxCount = 0;
//      for (int j = 0; j < s.Length - 1; j++)
//      {
//        if (s[j] == s[j + 1])
//        {
//          count++;
//          if (maxCount == 2)
//          {
//            twoPare = true;
//          }
//        }
//        else
//        {
//          maxCount = Math.Max(maxCount, count);
//          count = 1;
//        }
//      }
//      maxCount = Math.Max(maxCount, count);
//      if (maxCount == 4)
//      {
//        Console.WriteLine("Four Card");
//      }
//      else if (maxCount == 3)
//      {
//        Console.WriteLine("Three Card");
//      }
//      else if (maxCount == 2 && twoPare)
//      {
//        Console.WriteLine("Two Pair");
//      }
//      else if (maxCount == 2)
//      {
//        Console.WriteLine("One Pair");
//      }
//      else
//      {
//        Console.WriteLine("No Pair");
//      }
//    }
//  }
//}