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

//    int N = int.Parse(words[0]);
//    int H = int.Parse(words[1]);
//    int W = int.Parse(words[2]);

//    int[,] maps = new int[W, H];
//    Dictionary<int, int> players = new Dictionary<int, int>()
//        {{3,3 },{4,2 },{5,1 }};

//    for (int i = 1; i <= N * 3; i++)
//    {
//      words = Console.ReadLine().Split();
//      int startX = int.Parse(words[0]);
//      int startY = int.Parse(words[1]);
//      int s = int.Parse(words[2]);
//      int x = startX;
//      int y = startY;

//      int player = i % 3;
//      if (player == 0)
//        player = 3;

//      while (x < W && x - startX < s)
//      {
//        y = startY;
//        while (y < H && y - startY < s)
//        {
//          if (maps[x, y] == 0)
//            maps[x, y] += player;

//          else if (maps[x, y] != player)
//            maps[x, y] = players[maps[x, y] + player];

//          y++;
//        }
//        x++;
//      }
//    }

//    int[] points = new int[4];
//    for (int i = 0; i < W; i++)
//    {
//      for (int j = 0; j < H; j++)
//      {
//        points[maps[i, j]]++;
//      }
//    }

//    Console.WriteLine(points[1] + " " + points[2] + " " + points[3]);
//  }
//}
