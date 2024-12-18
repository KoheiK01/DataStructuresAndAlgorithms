//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 迷路 **********/
//    //STEP: 1 1 マスの移動
//    //int[] _firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1];
//    //int[] _secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int _nowy = _secondLine[0], _x = _secondLine[1];
//    //char[][] _grid = InitGrid(H, W);
//    //Move(_grid, _nowy, _x, H, W);
//    //ShowGrid(_grid, H);

//    //STEP: 2 3 マスの移動
//    //STEP: 3 N マスの移動
//    //int _moveLen = 3;
//    //int[] _firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1];
//    //int H = _firstLine[0], W = _firstLine[1]; _moveLen = _firstLine[2];
//    //int[] _secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int _y = _secondLine[0], _x = _secondLine[1];
//    //char[][] _grid = InitGrid(H, W);
//    //ShowBFS(_grid, _y, _x, H, W, _moveLen);
//    //ShowGrid(_grid, H);

//    //STEP: 4 壁のあるグリッドでの n マスの移動
//    //int[] _firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1], _moveLen = _firstLine[2];
//    //int[] _secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int _y = _secondLine[0], _x = _secondLine[1];
//    //char[][] _grid = ReadGrid(H);
//    //ShowBFS(_grid, _y, _x, H, W, _moveLen);
//    //ShowGrid(_grid, H);

//    //STEP: 5 ゴール判定
//    //int[] _firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = _firstLine[0], W = _firstLine[1];
//    //int[] _secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int _sy = _secondLine[0], _sx = _secondLine[1];
//    //int[] _thirdLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int _gy = _thirdLine[0], _gx = _thirdLine[1];
//    //char[][] _grid = ReadGrid(H);
//    //int _goalStep;
//    //bool _doGoal;
//    //(_doGoal, _goalStep) = JudgeGole(_grid, _sy, _sx, _gy, _gx, H, W);
//    //Console.WriteLine(_doGoal ? _goalStep.ToString() : "No");
//  }

//  private static char[][] InitGrid(int H, int W)
//  {
//    char[][] _grid = new char[H][];
//    for (int _h = 0; _h < H; _h++)
//    {
//      _grid[_h] = Enumerable.Repeat('.', W).ToArray();
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

//  private static void Move(char[][] _grid, int _nowy, int _nowx, int H, int W)
//  {
//    List<(int dy, int dx)> _directions = CreateDirections();
//    ChangeGrid(_grid, _nowy, _nowx);
//    foreach (var _direction in _directions)
//    {
//      (int _nexty, int _nextx) = (_nowy + _direction.dy, _nowx + _direction.dx);
//      if (Inrange(_nexty, _nextx, H, W))
//      {
//        ChangeGrid(_grid, _nexty, _nextx);
//      }
//    }
//  }

//  private static void ShowBFS(char[][] _grid, int _sy, int _sx, int H, int W, int _moveLen)
//  {
//    Queue<(int y, int x)> _queue = new Queue<(int y, int x)>();

//    ChangeGrid(_grid, _sy, _sx);
//    _queue.Enqueue((_sy, _sx));

//    List<(int dy, int dx)> _directions = CreateDirections();
//    for (int _len = 0; _len < _moveLen; _len++)
//    {
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        (int _nowy, int _nowx) = _queue.Dequeue();
//        foreach (var _direction in _directions)
//        {
//          (int _nexty, int _nextx) = (_nowy + _direction.dy, _nowx + _direction.dx);
//          if (Inrange(_nexty, _nextx, H, W) && _grid[_nexty][_nextx] == '.')
//          {
//            ChangeGrid(_grid, _nexty, _nextx);
//            _queue.Enqueue((_nexty, _nextx));
//          }
//        }
//      }
//    }
//  }

//  private static (bool, int) JudgeGole(char[][] _grid, int _sy, int _sx, int _gy, int _gx, int H, int W)
//  {
//    int _goalStep = 0;
//    Queue<(int sy, int sx)> _queue = new Queue<(int sy, int sx)>();
//    ChangeGrid(_grid, _sy, _sx);
//    _queue.Enqueue((_sy, _sx));
//    if (IsGoal(_sy, _sx, _gy, _gx))
//    {
//      return (true, 0);
//    }

//    List<(int dy, int dx)> _directions = CreateDirections();
//    while (_queue.Count > 0)
//    {
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        (int _nowy, int _nowx) = _queue.Dequeue();
//        if (IsGoal(_nowy, _nowx, _gy, _gx))
//        {
//          return (true, _goalStep);
//        }
//        foreach (var _direction in _directions)
//        {
//          (int _nexty, int _nextx) = (_nowy + _direction.dy, _nowx + _direction.dx);
//          if (Inrange(_nexty, _nextx, H, W) && _grid[_nexty][_nextx] == '.')
//          {
//            ChangeGrid(_grid, _nexty, _nextx);
//            _queue.Enqueue((_nexty, _nextx));
//          }
//        }
//      }
//      _goalStep++;
//    }

//    return (false, _goalStep);
//  }

//  private static bool IsGoal(int _y, int _x, int _gy, int _gx)
//  {
//    return _y == _gy && _x == _gx ? true : false;
//  }

//  private static List<(int dy, int dx)> CreateDirections()
//  {
//    return new List<(int dy, int dx)> { (1, 0), (-1, 0), (0, 1), (0, -1) };
//  }

//  private static void ChangeGrid(char[][] _grid, int _nexty, int _nextx)
//  {
//    _grid[_nexty][_nextx] = '*';
//  }

//  private static bool Inrange(int _nexty, int _nextx, int H, int W)
//  {
//    return 0 <= _nexty && _nexty < H && 0 <= _nextx && _nextx < W;
//  }

//  private static void ShowGrid(char[][] _grid, int H)
//  {
//    for (int _h = 0; _h < H; _h++)
//    {
//      Console.WriteLine(string.Join("", _grid[_h]));
//    }
//  }
//}