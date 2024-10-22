//using System;
//using System.Management.Instrumentation;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int sum = 0;
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string ans = words[0];
//      string mark = words[1];
//      if (ans == mark)
//      {
//        sum += 2;
//      }
//      else if (ans.Length == mark.Length)
//      {
//        int miss = 0;
//        for (int j = 0; j < ans.Length; j++)
//        {
//          if (ans[j] != mark[j])
//          {
//            miss++;
//          }
//        }
//        if (miss == 1)
//        {
//          sum++;
//        }
//      }
//    }
//    Console.WriteLine(sum);
//  }
//}