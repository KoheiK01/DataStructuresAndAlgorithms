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
//    int[,] _seats = new int[H, W];
//    for (int _i = 0; _i < N; _i++)
//    {
//      int _number = int.Parse(Console.ReadLine()) - 1;
//      int _y = _number / W;
//      int _x = _number % W;
//      _seats[_y, _x] = _i + 1;
//    }

//    for (int _x = 0; _x < W; _x++)
//    {
//      int _changeIndex = 0;
//      for (int _y = 0; _y < H; _y++)
//      {
//        if (_seats[_y, _x] != 0)
//        {
//          int _temp = _seats[_y, _x];
//          _seats[_y, _x] = 0;
//          _seats[_changeIndex, _x] = _temp;
//          _changeIndex++;
//        }
//      }
//    }

//    for (int _y = 0; _y < H; _y++)
//    {
//      for (int _x = 0; _x < W; _x++)
//      {
//        Console.Write(_x == W - 1 ? _seats[_y, _x] + "\n" : _seats[_y, _x] + " ");
//      }
//    }
//  }
//}