//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int W = _firstLine[0], H = _firstLine[1];
//    int _sy = 0, _sx = 0;
//    int _gy = 0, _gx = 0;
//    char[][] _grid = new char[H][];
//    for (int _y = 0; _y < H; _y++)
//    {
//      _grid[_y] = Console.ReadLine().Trim().Split().Select(char.Parse).ToArray();
//      for (int _x = 0; _x < W; _x++)
//      {
//        if (_grid[_y][_x] == 's')
//        {
//          (_sy, _sx) = (_y, _x);
//        }
//        else if (_grid[_y][_x] == 'g')
//        {
//          (_gy, _gx) = (_y, _x);
//        }
//      }
//    }

//    Console.WriteLine(Bfs(_grid, _sy, _sx, H, W));
//  }

//  private static string Bfs(char[][] _grid, int _sy, int _sx, int H, int W)
//  {
//    List<(int dy, int dx)> _directions = new List<(int dy, int dx)>() { (-1, 0), (0, 1), (1, 0), (0, -1) };
//    Queue<(int y, int x)> _queue = new Queue<(int y, int x)>();
//    _queue.Enqueue((_sy, _sx));
//    int _step = 0;

//    while (_queue.Count > 0)
//    {
//      _step++;
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        (int _y, int _x) = _queue.Dequeue();
//        foreach (var _direction in _directions)
//        {
//          (int _ny, int _nx) = (_y + _direction.dy, _x + _direction.dx);
//          if (Inrange(_ny, _nx, H, W))
//          {
//            if (_grid[_ny][_nx] == 'g')
//            {
//              return _step.ToString();
//            }
//            else if(_grid[_ny][_nx] == '0')
//            {
//              _queue.Enqueue((_ny, _nx));
//              _grid[_ny][_nx] = '1';
//            }
//          }
//        }
//      }
//    }

//    return "Fail";
//  }

//  private static bool Inrange(int _ny, int _nx, int H, int W)
//  {
//    return 0 <= _ny && _ny < H && 0 <= _nx && _nx < W;
//  }
//}
