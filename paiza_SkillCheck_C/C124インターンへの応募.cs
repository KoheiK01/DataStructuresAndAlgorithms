//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    bool[] nowIntern = new bool[1001];

//    int ans = 0;
//    int N = int.Parse(Console.ReadLine());
//    for (int i = 0; i < N; i++)
//    {
//      bool canThisCompany = false;
//      int num = int.Parse(Console.ReadLine());
//      for (int j = 0; j < num; j++)
//      {
//        bool canThisPeriod = false;
//        var words = Console.ReadLine().Split(' ');
//        int start = int.Parse(words[0]);
//        int period = int.Parse(words[1]);
//        for (int k = 0; k < period; k++)
//        {
//          if (nowIntern[start + k])
//          {
//            break;
//          }
//          else if (k == period - 1)
//          {
//            canThisPeriod = true;
//          }
//        }

//        if (canThisPeriod)
//        {
//          canThisCompany = true;
//          for (int k = 0; k < period; k++)
//          {
//            nowIntern[start + k] = true;
//          }
//        }
//      }
//      if (canThisCompany)
//      {
//        ans++;
//      }
//    }
//    Console.WriteLine(ans.ToString());
//  }
//}