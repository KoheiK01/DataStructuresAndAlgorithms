//using System;
//using System.Diagnostics;
//using System.Security.Cryptography;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int M = int.Parse(words[0]);
//    int N = int.Parse(words[1]);
//    int x = int.Parse(words[2]);

//    int ans = 0;
//    int remain = x;
//    for (int i = 0; i < M; i++)
//    {
//      int w = int.Parse(Console.ReadLine());
//      if (remain > w)
//      {
//        remain -= w;
//        ans++;
//      }
//      else
//      {
//        if (w >= x)
//        {
//          break;
//        }

//        N--;
//        if (N == 0)
//        {
//          break;
//        }
//        remain = x - w;
//        ans++;
//      }
//    }

//    Console.WriteLine(ans);
//  }
//}