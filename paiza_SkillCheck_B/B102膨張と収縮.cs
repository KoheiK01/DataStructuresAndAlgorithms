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
//    int H = _firstLine[0], W = _firstLine[1], N = _firstLine[2];
//    char[][] _image = new char[H][];
//    for (int _y = 0; _y < H; _y++)
//    {
//      _image[_y] = Console.ReadLine().Trim().ToCharArray();
//    }
//    string _operation = Console.ReadLine().Trim();
//    for (int _i = 0; _i < N; _i++)
//    {
//      char _operate = _operation[_i];

//      if (_operate == 'D')
//      {
//        bool[][] _marks = Mark(_image, H, W, '#');
//        ChangeImage(_image, _marks, H, W, '#');
//      }
//      else
//      {
//        bool[][] _marks = Mark(_image, H, W, '.');
//        ChangeImage(_image, _marks, H, W, '.');
//      }
//    }

//    for (int _y = 0; _y < H; _y++)
//    {
//      Console.WriteLine(string.Join("", _image[_y]));
//    }
//  }
//  private static bool Inrange(int _ny, int _nx, int H, int W)
//  {
//    return 0 <= _ny && _ny < H && 0 <= _nx && _nx < W;
//  }


//  private static bool[][] Mark(char[][] _image, int H, int W, char _color)
//  {
//    List<(int dy, int dx)> _moves = new List<(int dy, int dx)>()
//    {
//      (-1,0),(0,1),(1,0),(0,-1)
//    };
//    bool[][] _marks = new bool[H][];
//    for (int _y = 0; _y < H; _y++)
//    {
//      _marks[_y] = new bool[W];
//    }

//    for (int _y = 0; _y < H; _y++)
//    {
//      for (int _x = 0; _x < W; _x++)
//      {
//        if (_image[_y][_x] != _color) continue;
//        foreach (var _move in _moves)
//        {
//          (int _ny, int _nx) = (_y + _move.dy, _x + _move.dx);
//          if (Inrange(_ny, _nx, H, W) && !_marks[_ny][_nx] && _image[_ny][_nx] != _color)
//          {
//            _marks[_ny][_nx] = true;
//          }
//        }
//      }
//    }
//    return _marks;
//  }


//  private static void ChangeImage(char[][] _image, bool[][] _marks, int H, int W, char _color)
//  {
//    for (int _y = 0; _y < H; _y++)
//    {
//      for (int _x = 0; _x < W; _x++)
//      {
//        if (_marks[_y][_x])
//        {
//          _image[_y][_x] = _color;
//        }
//      }
//    }
//  }
//}