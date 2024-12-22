//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int N = int.Parse(words[0]);
//    int M = int.Parse(words[1]);
//    int[,] Fares = new int[N, M];

//    for (int i = 0; i < N; i++)
//    {
//      words = Console.ReadLine().Split();
//      for (int j = 0; j < M; j++)
//      {
//        Fares[i, j] = int.Parse(words[j]);
//      }
//    }

//    int sum = 0;
//    int X = int.Parse(Console.ReadLine());
//    int startStation = 1;
//    for (int i = 0; i < X; i++)
//    {
//      words = Console.ReadLine().Split();
//      int useRoute = int.Parse(words[0]);
//      int goalStation = int.Parse(words[1]);

//      sum += Math.Abs(Fares[useRoute - 1, goalStation - 1] - Fares[useRoute - 1, startStation - 1]);
//      startStation = goalStation;
//    }

//    Console.WriteLine(sum);
//  }
//}