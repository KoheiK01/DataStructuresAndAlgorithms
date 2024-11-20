//using System;
//using System.Collections.Generic;
//using System.Linq;
//public class MainApp
//{
//  //static public void Main(string[] args)
//  public static void Main()
//  {
//    // このコードは標準入力と標準出力を用いたサンプルコードです。
//    // このコードは好きなように編集・削除してもらって構いません。
//    // ---
//    // This is a sample code to use stdin and stdout.
//    // Edit and remove this code as you like.

//    var lines = GetStdin();

//    int[] _firstLine = lines[0].Split().Select(int.Parse).ToArray();
//    int _n = _firstLine[0], _m = _firstLine[1], _q = _firstLine[2];

//    int[,] _map = new int[_n, _m];
//    for (int _i = 0; _i < _q; _i++)
//    {
//      int[] _line = lines[_i + 1].Split().Select(int.Parse).ToArray();
//      int _s = _line[0], _t = _line[1], _x = _line[2];
//      _map[_s, _t] = _x;
//    }

//    DiceSolver _solver = new DiceSolver(_map, _n, _m);
//    int _result = _solver.Solve();

//    Console.WriteLine(_result == -1 ? "NO" : "YES\n" + _result);
//  }


//  static private string[] GetStdin()
//  {
//    var list = new List<string>();
//    string line;
//    while ((line = Console.ReadLine()) != null)
//    {
//      list.Add(line);
//    }
//    return list.ToArray();
//  }
//}


//public class Dice
//{
//  public int X;
//  public int Y;
//  public int Top;
//  public int Front;
//  public int Right;
//  public int Back;
//  public int Left;

//  public Dice(int _y, int _x, int _top, int _front, int _right)
//  {
//    Y = _y;
//    X = _x;
//    Top = _top;
//    Front = _front;
//    Right = _right;
//    Back = 7 - _front;
//    Left = 7 - _right;
//  }

//  public static readonly int[][] s_Directions =
//  {
//        new[] { 1, 0 }, // 南
//        new[] { 0, 1 }, // 右
//    };

//  public Dice Roll(int[] _directions)
//  {
//    int _newTop, _newFront, _newRight;
//    if (_directions[0] == 1)
//    {
//      _newTop = Back;
//      _newFront = Top;
//      _newRight = Right;
//    }
//    else
//    {
//      _newTop = Left;
//      _newFront = Front;
//      _newRight = Top;
//    }
//    return new Dice(Y + _directions[0], X + _directions[1], _newTop, _newFront, _newRight);
//  }
//}

//public class DiceSolver
//{
//  private readonly int[,] map;
//  private readonly int n;
//  private readonly int m;
//  private int minStep;

//  public DiceSolver(int[,] _map, int _n, int _m)
//  {
//    map = _map;
//    n = _n;
//    m = _m;
//    minStep = int.MaxValue;
//  }

//  public int Solve()
//  {
//    Dice _initialDice = new Dice(0, 0, 1, 2, 4);
//    Dictionary<(int, int, int), Dice> _visited = new Dictionary<(int, int, int), Dice>
//    {
//      { (0, 0, 1), _initialDice }
//    };
//    DFS(_initialDice, 0, _visited);
//    return minStep == int.MaxValue ? -1 : minStep;
//  }

//  private void DFS(Dice _dice, int _step, Dictionary<(int, int, int), Dice> _visited)
//  {
//    if (_step >= minStep) return;

//    if (_dice.Y == n - 1 && _dice.X == m - 1)
//    {
//      minStep = Math.Min(minStep, _step);
//      return;
//    }

//    foreach (var _direction in Dice.s_Directions)
//    {
//      Dice _nextDice = _dice.Roll(_direction);
//      if (IsOutSide(_nextDice.Y, _nextDice.X) && map[_nextDice.Y, _nextDice.X] != _nextDice.Top)
//      {
//        var _position = (_nextDice.Y, _nextDice.X, _nextDice.Top);
//        if (!_visited.ContainsKey(_position))
//        {
//          _visited.Add(_position, _nextDice);
//          DFS(_nextDice, _step + 1, _visited);
//          _visited.Remove(_position);
//        }
//      }
//    }
//  }

//  private bool IsOutSide(int _y, int _x)
//  {
//    return _y < n && _x < m;
//  }
//}
