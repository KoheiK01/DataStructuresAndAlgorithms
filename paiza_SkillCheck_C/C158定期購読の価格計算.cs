//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int N = NM[0], M = NM[1];
//    bool[,] getweek = new bool[N, M];
//    int[] prices = new int[N];
//    for (int good = 0; good < N; good++)
//    {
//      int[] fp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      int week = 0;
//      while (week < M)
//      {
//        getweek[good, week] = true;
//        week += fp[0];
//      }
//      prices[good] = fp[1];
//    }
//    int ans = 0;
//    for (int week = 0; week < M; week++)
//    {
//      int weekPrice = 0;
//      int goodNum = 0;
//      for (int good = 0; good < N; good++)
//      {
//        if (getweek[good, week])
//        {
//          goodNum++;
//          weekPrice += prices[good];
//        }
//      }
//      if (goodNum == 2)
//      {
//        weekPrice = (int)(weekPrice * 0.9);
//      }
//      else if (goodNum >= 3)
//      {
//        weekPrice = (int)(weekPrice * 0.85);
//      }
//      ans += weekPrice;
//    }
//    Console.WriteLine(ans);
//  }
//}
