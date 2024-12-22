//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1];
//    int[][] _trains = new int[N][];
//    for (int i = 0; i < N; i++)
//    {
//      _trains[i] = new int[] { i };
//    }
//    for (int i = 0; i < M; i++)
//    {
//      int[] _inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _winner = _inputs[0] - 1;
//      int _loser = _inputs[1] - 1;
//      _trains[_winner] = _trains[_winner].Concat(_trains[_loser]).ToArray();
//      _trains[_loser] = null;
//    }

//    int _topCount = 0;
//    for (int i = 0; i < N; i++)
//    {
//      if (_trains[i] != null && _trains[i].Length > _topCount)
//      {
//        _topCount = _trains[i].Length;
//      }
//    }

//    for (int i = 0; i < N; i++)
//    {
//      if (_trains[i] != null && _trains[i].Length == _topCount)
//      {
//        Console.WriteLine(i + 1);
//      }
//    }
//  }
//}