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

//    int[,] map = new int[N, N];
//    List<int> canGo = new List<int>();
//    bool canWait = true;

//    for (int i = 0; i < N; i++)
//    {
//      words = Console.ReadLine().Split();
//      for (int j = 0; j < N; j++)
//      {
//        int temp = int.Parse(words[j]);
//        map[j, i] = temp;
//      }
//    }

//    for (int i = 0; i < N; i++)
//    {
//      for (int j = 0; j < N; j++)
//      {
//        if (map[i, j] >= M)
//          break;
//        else if (j == N - 1)
//        {
//          canWait = false;
//          canGo.Add(i + 1);
//        }
//      }
//    }

//    if (canWait)
//      Console.WriteLine("wait");
//    else
//      Console.WriteLine(String.Join(" ", canGo));
//  }
//}
