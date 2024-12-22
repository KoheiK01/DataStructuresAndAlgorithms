//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int reserved = int.Parse(words[0]);
//    int H = int.Parse(words[1]);
//    int W = int.Parse(words[2]);
//    int bestP = int.Parse(words[3]);
//    int bestQ = int.Parse(words[4]);
//    bool[,] doReserved = new bool[H, W];
//    int[,] distances = new int[H, W];
//    int distanceMin = int.MaxValue;

//    for (int i = 0; i < reserved; i++)
//    {
//      words = Console.ReadLine().Split();
//      int p = int.Parse(words[0]);
//      int q = int.Parse(words[1]);
//      doReserved[p, q] = true;
//    }

//    for (int p = 0; p < H; p++)
//    {
//      for (int q = 0; q < W; q++)
//      {
//        if (!doReserved[p, q])
//        {
//          int distance = Math.Abs(p - bestP) + Math.Abs(q - bestQ);
//          distances[p, q] = distance;
//          distanceMin = Math.Min(distanceMin, distance);
//        }
//      }
//    }

//    for (int p = 0; p < H; p++)
//    {
//      for (int q = 0; q < W; q++)
//      {
//        if (!doReserved[p, q] && distanceMin == distances[p, q])
//        {
//          Console.Write(p + " ");
//          Console.WriteLine(q);
//        }
//      }
//    }
//  }
//}