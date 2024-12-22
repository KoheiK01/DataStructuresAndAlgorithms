//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int H = _firstLine[0], W = _firstLine[1];
//    char[][] _flowers = new char[H][];
//    int _flowerCount = 0;
//    for (int _y = 0; _y < H; _y++)
//    {
//      _flowers[_y] = Console.ReadLine().Trim().ToCharArray();
//    }

//    List<(int dy, int dx)> _moves = new List<(int dy, int dx)>()
//    {
//      (-1,0),(0,1),(1,0),(0,-1)
//    };
//    int _ropeCount = 0;
//    for (int _y = 0; _y < H; _y++)
//    {
//      for (int _x = 0; _x < W; _x++)
//      {
//        if (_flowers[_y][_x] != '#') continue;
//        int _aroundFlowerCount = 0;
//        foreach (var _move in _moves)
//        {
//          (int _ny, int _nx) = (_y + _move.dy, _x + _move.dx);
//          if (Inrange(_ny, _nx, H, W) && _flowers[_ny][_nx] == '#')
//          {
//            _aroundFlowerCount++;
//          }
//        }
//        _ropeCount += 4 - _aroundFlowerCount;
//      }
//    }
//    Console.WriteLine(_ropeCount);
//  }
//  private static bool Inrange(int _ny, int _nx, int H, int W)
//  {
//    return 0 <= _ny && _ny < H && 0 <= _nx && _nx < W;
//  }
//}