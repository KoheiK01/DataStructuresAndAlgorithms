//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1], T = _firstLine[2], K = _firstLine[3];

//    int[][] _goodCounts = new int[M][];
//    for (int _time = 0; _time < M; _time++)
//    {
//      _goodCounts[_time] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    }


//    for (int _post = 0; _post < N; _post++)
//    {
//      int _sums = 0;
//      for (int _time = 0; _time < M; _time++)
//      {
//        if (_time >= T)
//        {
//          _sums -= _goodCounts[_time - T][_post];
//        }
//        _sums += _goodCounts[_time][_post];
//        if (_sums >= K)
//        {
//          Console.WriteLine($"yes {_time + 1}");
//          break;
//        }
//        if (_time == M - 1)
//        {
//          Console.WriteLine($"no 0");
//        }
//      }
//    }
//  }
//}