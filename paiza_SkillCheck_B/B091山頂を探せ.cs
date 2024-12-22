//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());
//    int[][] _heights = new int[N][];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _heights[_i] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    }

//    List<(int dy, int dx)> _moves = new List<(int dy, int dx)>()
//    {
//      (-1,0),(0,1),(1,0),(0,-1)
//    };
//    List<int> _tops = new List<int>();
//    for (int _y = 0; _y < N; _y++)
//    {
//      for (int _x = 0; _x < N; _x++)
//      {
//        bool _top = true;
//        int _height = _heights[_y][_x];
//        foreach (var _move in _moves)
//        {
//          (int _ny, int _nx) = (_y + _move.dy, _x + _move.dx);
//          if (Inrange(_ny, _nx, N) && _heights[_ny][_nx] >= _height)
//          {
//            _top = false;
//          }
//        }
//        if (_top)
//        {
//          _tops.Add(_height);
//        }
//      }
//    }
//    _tops = _tops.OrderByDescending(x => x).ToList();
//    Console.WriteLine(string.Join("\n", _tops));
//  }
//  private static bool Inrange(int _ny, int _nx, int N)
//  {
//    return 0 <= _ny && _ny < N && 0 <= _nx && _nx < N;
//  }
//}