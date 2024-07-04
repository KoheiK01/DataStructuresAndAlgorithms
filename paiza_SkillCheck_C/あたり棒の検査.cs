//using System;
//using System.Management.Instrumentation;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int m = int.Parse(words[1]);

//    words = Console.ReadLine().Split(' ');
//    int[] a = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//      a[i] = int.Parse(words[i]);
//    }

//    string ans = "OK";
//    for (int i = 0; i <= n - m; i++)
//    {
//      int sum = 0;
//      for (int j = 0; j < m; j++)
//      {
//        sum += a[i + j];
//      }
//      if (sum == 0)
//      {
//        ans = "NG";
//        break;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}