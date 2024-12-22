//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());
//    int[][] _times = new int[N][];
//    bool[][] _visited = new bool[N][];
//    for (int _row = 0; _row < N; _row++)
//    {
//      _times[_row] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      _visited[_row] = new bool[N];
//    }
//    int _showTime = N * N / 4;

//    int _y = 0, _x = 0;
//    (int _dy, int _dx) = (0, 1);
//    int _count = 1;
//    int _sumTime = _times[0][0];
//    _visited[_y][_x] = true;
//    if (_count % _showTime == 0)
//    {
//      Console.WriteLine(_sumTime);
//    }
//    while (_count != N * N)
//    {
//      (int _ny, int _nx) = (_y + _dy, _x + _dx);
//      if (_dy == 0 && _dx == 1 && (_nx == N || _visited[_ny][_nx]))
//      {
//        (_dy, _dx) = (1, 0);
//      }
//      else if (_dy == 1 && _dx == 0 && (_ny == N || _visited[_ny][_nx]))
//      {
//        (_dy, _dx) = (0, -1);
//      }
//      else if (_dy == 0 && _dx == -1 && (_nx == -1 || _visited[_ny][_nx]))
//      {
//        (_dy, _dx) = (-1, 0);
//      }
//      else if (_dy == -1 && _dx == 0 && (_ny == -1 || _visited[_ny][_nx]))
//      {
//        (_dy, _dx) = (0, 1);
//      }
//      else
//      {
//        _count++;
//        _sumTime += _times[_ny][_nx];
//        _visited[_ny][_nx] = true;
//        (_y, _x) = (_ny, _nx);
//        if (_count % _showTime == 0)
//        {
//          Console.WriteLine(_sumTime);
//        }
//      }
//    }
//  }
//}