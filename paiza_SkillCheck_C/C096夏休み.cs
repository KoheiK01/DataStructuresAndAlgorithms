//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int[] frees = new int[32];
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int s = int.Parse(words[0]);
//      int e = int.Parse(words[1]);
//      for (int j = s; j <= e; j++)
//      {
//        frees[j]++;
//      }
//    }

//    string ans = "NG";
//    for (int i = 1; i <= 31; i++)
//    {
//      if (frees[i] == n)
//      {
//        ans = "OK";
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}