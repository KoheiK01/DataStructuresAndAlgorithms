//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 領域の個数 **********/
//    //STEP: 1 グリッドの深さ優先探索（3 マス）
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1], _sy = _firstLine[2], _sx = _firstLine[3];
//    //int[][] _grid = InitGrid(H, W);
//    //int _maxStep = 3;
//    //ShowDFS(_sy, _sx, 0, _maxStep, H, W);

//    //FINAL問題 領域の個数
//    //int[] _firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1];
//    //char[][] _grid = ReadGrid(H);
//    //int _ans = 0;
//    //for (int _h = 0; _h < H; _h++)
//    //{
//    //  for (int _w = 0; _w < W; _w++)
//    //  {
//    //    if (_grid[_h][_w] == '.')
//    //    {
//    //      ChangeGridByDfs(_grid, _h, _w, H, W);
//    //      _ans++;
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(_ans);
//  }

//  private static void ChangeGridByDfs(char[][] _grid, int _y, int _x, int H, int W)
//  {
//    _grid[_y][_x] = 'v';
//    List<(int dy, int dx)> _directions = new List<(int dy, int dx)> { (-1, 0), (0, 1), (1, 0), (0, -1) };
//    foreach (var _direction in _directions)
//    {
//      (int _ny, int _nx) = (_y + _direction.dy, _x + _direction.dx);
//      if (Inrange(_ny, _nx, H, W) && _grid[_ny][_nx] == '.')
//      {
//        ChangeGridByDfs(_grid, _ny, _nx, H, W);
//      }
//    }
//  }

//  //Stack
//  private static void ShowDFS(int[][] _grid, int _sy, int _sx, int _maxStep, int H, int W)
//  {
//    List<(int dy, int dx)> _directions = CreateDirections();
//    Stack<(int y, int x, int step)> _stack = new Stack<(int y, int x, int step)>();
//    _stack.Push((_sy, _sx, 0));
//    ChangeGrid(_grid, _sy, _sx, 0);

//    while (_stack.Count > 0)
//    {
//      (int _y, int _x, int _step) = _stack.Pop();
//      if (_step == _maxStep)
//      {
//        Console.WriteLine(_y + " " + _x);
//        continue;
//      }
//      foreach (var _direction in _directions)
//      {
//        (int _ny, int _nx) = (_y + _direction.dy, _x + _direction.dx);
//        if (Inrange(_ny, _nx, H, W))
//        {
//          _stack.Push((_ny, _nx, _step + 1));
//          ChangeGrid(_grid, _ny, _nx, _step + 1);
//        }
//      }
//    }
//  }

//  //再起
//  private static void ShowDFS(int _y, int _x, int _step, int _maxStep, int H, int W)
//  {
//    if (_step == _maxStep)
//    {
//      Console.WriteLine($"{_y} {_x}");
//      return;
//    }
//    List<(int dy, int dx)> _directions = new List<(int dy, int dx)> { (-1, 0), (0, 1), (1, 0), (0, -1) };
//    foreach (var _direction in _directions)
//    {
//      (int _ny, int _nx) = (_y + _direction.dy, _x + _direction.dx);
//      if (Inrange(_ny, _nx, H, W))
//      {
//        ShowDFS(_ny, _nx, _step + 1, _maxStep, H, W);
//      }
//    }
//  }

//  private static bool Inrange(int _nexty, int _nextx, int H, int W)
//  {
//    return 0 <= _nexty && _nexty < H && 0 <= _nextx && _nextx < W;
//  }

//  private static void ChangeGrid(int[][] _grid, int _y, int _x, int _step)
//  {
//    _grid[_y][_x] = _step;
//  }

//  private static List<(int dy, int dx)> CreateDirections()
//  {
//    return new List<(int dy, int dx)> { (0, -1), (1, 0), (0, 1), (-1, 0) };
//  }

//  private static int[][] InitGrid(int H, int W)
//  {
//    int[][] _grid = new int[H][];
//    for (int _h = 0; _h < H; _h++)
//    {
//      _grid[_h] = Enumerable.Repeat(-1, W).ToArray();
//    }
//    return _grid;
//  }

//  private static char[][] ReadGrid(int H)
//  {
//    char[][] _grid = new char[H][];
//    for (int _h = 0; _h < H; _h++)
//    {
//      _grid[_h] = Console.ReadLine().ToCharArray();
//    }
//    return _grid;
//  }
//}
