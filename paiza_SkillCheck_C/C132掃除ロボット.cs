//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int m = int.Parse(Console.ReadLine());
//    bool[] didCreaning = new bool[n + 1];

//    int didCreanCount = 0;
//    int index = 1;
//    while ((!didCreaning[index]))
//    {
//      didCreaning[index] = true;
//      didCreanCount++;
//      if (didCreanCount == n)
//      {
//        break;
//      }
//      if (index + m <= n)
//      {
//        index += m;
//      }
//      else
//      {
//        index = (index + m) % n;
//      }
//    }

//    if (didCreanCount == n)
//    {
//      Console.WriteLine("yes");
//    }
//    else
//    {
//      Console.WriteLine("no");
//    }
//  }
//}