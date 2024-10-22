//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int N = int.Parse(Console.ReadLine());

//    char[,] maps = new char[N, N];
//    for (int i = 0; i < N; i++)
//    {
//      maps[i, i] = '-';
//    }

//    for (int i = 0; i < N * (N - 1) / 2; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int f = int.Parse(words[0]);
//      int s = int.Parse(words[1]);
//      maps[f - 1, s - 1] = 'W';
//      maps[s - 1, f - 1] = 'L';
//    }

//    for (int i = 0; i < N; i++)
//    {
//      for (int j = 0; j < N; j++)
//      {
//        if (j != N - 1)
//        {
//          Console.Write(maps[i, j] + " ");
//        }
//        else
//        {
//          Console.WriteLine(maps[i, j]);
//        }
//      }
//    }
//  }
//}