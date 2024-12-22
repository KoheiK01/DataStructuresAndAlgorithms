//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int H = _firstLine[0], W = _firstLine[1];
//    char[][] _map = new char[H][];
//    for (int _y = 0; _y < H; _y++)
//    {
//      _map[_y] = Console.ReadLine().Trim().ToCharArray();
//    }

//    (bool[] _rowMarks, bool[] _colMarks) = Mark(_map, H, W);
//    int _rowBomCount = _rowMarks.Count(_i => _i);
//    int _colBomCount = _colMarks.Count(_i => _i);
//    int _ans = _rowBomCount * W + _colBomCount * (H - _rowBomCount);
//    Console.WriteLine(_ans);
//  }

//  private static (bool[], bool[]) Mark(char[][] _map, int H, int W)
//  {
//    bool[] _rowMarks = new bool[H];
//    bool[] _colMarks = new bool[W];
//    for (int _y = 0; _y < H; _y++)
//    {
//      for (int _x = 0; _x < W; _x++)
//      {
//        if (_map[_y][_x] == '#')
//        {
//          _rowMarks[_y] = true;
//          _colMarks[_x] = true;
//        }
//      }
//    }
//    return (_rowMarks, _colMarks);
//  }
//}