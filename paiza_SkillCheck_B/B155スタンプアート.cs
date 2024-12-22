//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int H = _firstLine[0], W = _firstLine[1], N = _firstLine[2];

//    string[][] _stamps = new string[N][];
//    for (int _num = 0; _num < N; _num++)
//    {
//      _stamps[_num] = new string[H];
//      for (int _y = 0; _y < H; _y++)
//      {
//        _stamps[_num][_y] = Console.ReadLine();
//      }
//    }

//    int[] _secondLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int R = _secondLine[0], C = _secondLine[1];

//    int[][] _artPlan = new int[R][];
//    for (int i = 0; i < R; i++)
//    {
//      _artPlan[i] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    }

//    char[,] _art = new char[R * H, C * W];
//    for (int _r = 0; _r < R; _r++)
//    {
//      for (int _c = 0; _c < C; _c++)
//      {
//        string[] _useStamp = _stamps[_artPlan[_r][_c] - 1];
//        for (int _h = 0; _h < H; _h++)
//        {
//          for (int _w = 0; _w < W; _w++)
//          {
//            _art[_r * H + _h, _c * W + _w] = _useStamp[_h][_w];
//          }
//        }
//      }
//    }

//    for (int _row = 0; _row < R * H; _row++)
//    {
//      for (int _col = 0; _col < C * W; _col++)
//      {
//        Console.Write(_art[_row, _col]);
//      }
//      Console.WriteLine();
//    }
//  }
//}