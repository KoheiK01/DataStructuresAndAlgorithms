//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int N = int.Parse(Console.ReadLine());
//    Dictionary<string, Sox> soxes = new Dictionary<string, Sox>();

//    int ans = 0;
//    for (int i = 0; i < N; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      string ti = words[0];
//      string di = words[1];

//      if (soxes.ContainsKey(ti))
//      {
//        if (di == "R")
//        {
//          if (soxes[ti].Left >= 1)
//          {
//            ans++;
//            soxes[ti].Left--;
//          }
//          else
//          {
//            soxes[ti].Right++;
//          }
//        }
//        else
//        {
//          if (soxes[ti].Right >= 1)
//          {
//            ans++;
//            soxes[ti].Right--;
//          }
//          else
//          {
//            soxes[ti].Left++;
//          }
//        }
//      }
//      else
//      {
//        if (di == "R")
//        {
//          soxes.Add(ti, new Sox { Right = 1 });
//        }
//        else
//        {
//          soxes.Add(ti, new Sox { Left = 1 });
//        }
//      }
//    }

//    Console.WriteLine(ans);
//  }
//}
//class Sox
//{
//  public int Right = 0;
//  public int Left = 0;
//}
