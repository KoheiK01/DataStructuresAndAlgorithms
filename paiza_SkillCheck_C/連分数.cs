//using System;
//using System.Management.Instrumentation;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int[] xs = new int[n + 1];

//    for (int i = 1; i <= n; i++)
//    {
//      int x = int.Parse(Console.ReadLine());
//      xs[i] = x;
//    }

//    int up = 1;
//    int down = xs[n];
//    for (int i = n; i >= 2; i--)
//    {
//      int temp = down;
//      down = up + down * xs[i - 1];
//      up = temp;
//    }
//    Console.WriteLine(down + " " + up);
//  }
//}