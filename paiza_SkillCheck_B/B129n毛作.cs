//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static int count = 0;
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int n = int.Parse(words[0]);
//    int Kind = int.Parse(words[1]);
//    int[] Harvests = new int[Kind + 1];

//    words = Console.ReadLine().Split();
//    int height = int.Parse(words[0]);
//    int width = int.Parse(words[1]);
//    int[,] map = new int[height, width];

//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split();
//      int a = int.Parse(words[0]), b = int.Parse(words[1]),
//          c = int.Parse(words[2]), d = int.Parse(words[3]),
//          e = int.Parse(words[4]);

//      for (int h = a - 1; h < b; h++)
//      {
//        for (int w = c - 1; w < d; w++)
//        {
//          if (map[h, w] != 0)
//            Harvests[map[h, w]]++;
//          map[h, w] = e;
//        }
//      }
//    }

//    for (int i = 1; i <= Kind; i++)
//    {
//      Console.WriteLine(Harvests[i]);
//    }

//    for (int h = 0; h < height; h++)
//    {
//      for (int w = 0; w < width; w++)
//      {
//        if (map[h, w] == 0)
//          Console.Write(".");
//        else
//          Console.Write(map[h, w]);
//      }
//      Console.WriteLine();
//    }
//  }
//}
