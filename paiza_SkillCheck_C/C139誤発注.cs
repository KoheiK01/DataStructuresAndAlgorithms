//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    bool[] bools = new bool[n];
//    for (int i = 0; i < n; i++)
//    {
//      int x = int.Parse(Console.ReadLine());
//      if (x - 1 < n)
//      {
//        bools[x - 1] = true;
//      }
//    }
//    int ans = 0;
//    for (int i = 0; i < n; i++)
//    {
//      if (!bools[i]) ans++;
//    }
//    Console.WriteLine(ans);
//  }
//}