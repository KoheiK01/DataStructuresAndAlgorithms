//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int r = int.Parse(words[1]);

//    int max = 0;
//    int[] sales = new int[n + 1];
//    for (int i = 1; i <= n; i++)
//    {
//      int a = int.Parse(Console.ReadLine());
//      sales[i] = a / r;
//      max = Math.Max(max, sales[i]);
//    }

//    for (int i = 1; i <= n; i++)
//    {
//      Console.Write(i + ":");
//      for (int j = 1; j <= max; j++)
//      {
//        if (j <= sales[i])
//        {
//          Console.Write("*");
//        }
//        else
//        {
//          Console.Write(".");
//        }
//      }
//      Console.WriteLine();
//    }
//  }
//}