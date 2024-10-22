//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int k = int.Parse(words[1]);

//    int nearlyEarly = int.MinValue;
//    int nearlyLate = int.MaxValue;
//    for (int i = 0; i < n; i++)
//    {
//      int time = int.Parse(Console.ReadLine());
//      if (time <= k)
//      {
//        nearlyEarly = Math.Max(nearlyEarly, time);
//      }
//      else
//      {
//        nearlyLate = Math.Min(nearlyLate, time);
//      }
//    }
//    if (k - nearlyEarly == nearlyLate - k)
//    {
//      Console.WriteLine(nearlyEarly);
//      Console.WriteLine(nearlyLate);
//    }
//    else if (k - nearlyEarly < nearlyLate - k)
//    {
//      Console.WriteLine(nearlyEarly);
//    }
//    else
//    {
//      Console.WriteLine(nearlyLate);
//    }
//  }
//}