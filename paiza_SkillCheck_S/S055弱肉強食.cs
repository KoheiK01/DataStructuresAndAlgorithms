//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int H = _firstLine[0], W = _firstLine[1];
//    char[][] _grid = ReadGrid(H);
//    int N = int.Parse(Console.ReadLine());
//    var (_eatAnimals, _loseCounts) = ReadRelations(N);
//    Queue<char> _queue = new Queue<char>();
//    foreach (var _item in _loseCounts)
//    {
//      char _animal = _item.Key;
//      int _loseCount = _item.Value;
//      if (_loseCount == 0)
//      {
//        _queue.Enqueue(_animal);
//      }
//    }

//    List<(int dy, int dx)> _moves = new List<(int dy, int dx)>
//    {
//      (-1,0),(-1,1),(0,1),(1,1),(1,0),(1,-1),(0,-1),(-1,-1)
//    };

//    while (_queue.Count > 0)
//    {
//      char _boss = _queue.Dequeue();
//      for (int _y = 0; _y < H; _y++)
//      {
//        for (int _x = 0; _x < W; _x++)
//        {
//          if (_grid[_y][_x] == _boss)
//          {
//            foreach (var _move in _moves)
//            {
//              (int _ny, int _nx) = (_y + _move.dy, _x + _move.dx);
//              if (Inrange(_ny, _nx, H, W))
//              {
//                char _prey = _grid[_ny][_nx];
//                if (_eatAnimals.ContainsKey(_boss) && _eatAnimals[_boss].Contains(_prey))
//                {
//                  _grid[_ny][_nx] = '-';
//                }
//              }
//            }
//          }
//        }
//      }

//      if (_eatAnimals.ContainsKey(_boss))
//      {
//        foreach (var _prey in _eatAnimals[_boss])
//        {
//          _loseCounts[_prey]--;
//          if (_loseCounts[_prey] == 0)
//          {
//            _queue.Enqueue(_prey);
//          }
//        }
//      }
//    }

//    for (int _y = 0; _y < H; _y++)
//    {
//      Console.WriteLine(string.Join(" ", _grid[_y]));
//    }
//  }

//  private static bool Inrange(int _ny, int _nx, int H, int W)
//  {
//    return 0 <= _ny && _ny < H && 0 <= _nx && _nx < W;
//  }

//  private static char[][] ReadGrid(int H)
//  {
//    char[][] _grid = new char[H][];
//    for (int _y = 0; _y < H; _y++)
//    {
//      _grid[_y] = Console.ReadLine().Split().Select(char.Parse).ToArray();
//    }
//    return _grid;
//  }

//  private static (Dictionary<char, List<char>>, Dictionary<char, int>) ReadRelations(int N)
//  {
//    Dictionary<char, List<char>> _eatAnimals = new Dictionary<char, List<char>>();
//    Dictionary<char, int> _loseCounts = new Dictionary<char, int>();

//    for (int _i = 0; _i < N; _i++)
//    {
//      char[] _relation = Console.ReadLine().Split().Select(char.Parse).ToArray();
//      char _winner = _relation[0];
//      char _loser = _relation[1];
//      if (!_eatAnimals.ContainsKey(_winner))
//      {
//        _eatAnimals[_winner] = new List<char>();
//      }
//      if (!_loseCounts.ContainsKey(_loser))
//      {
//        _loseCounts[_loser] = 0;
//      }
//      if (!_loseCounts.ContainsKey(_winner))
//      {
//        _loseCounts[_winner] = 0;
//      }
//      _eatAnimals[_winner].Add(_loser);
//      _loseCounts[_loser]++;
//    }
//    return (_eatAnimals, _loseCounts);
//  }
//}
