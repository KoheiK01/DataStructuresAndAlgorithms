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
//    int[][] _picture1 = ReadPicture(H);
//    int[][] _picture2 = ReadPicture(H);

//    int[][] _finePicture1 = FinePicture(H, W, _picture1);
//    int[][] _finePicture2 = FinePicture(H, W, _picture2);

//    int[][] _comPicture = new int[2 * H - 1][];
//    for (int _h = 0; _h < 2 * H - 1; _h++)
//    {
//      int[] _temp = _finePicture2[_h].Take(2 * W - 1).ToArray();
//      _comPicture[_h] = _finePicture1[_h + 1].Skip(1).ToArray();
//      for (int _w = 0; _w < 2 * W - 1; _w++)
//      {
//        _comPicture[_h][_w] = (_comPicture[_h][_w] + _temp[_w]) / 2;
//      }
//    }
//    for (int _h = 0; _h < 2 * H - 1; _h++)
//    {
//      Console.WriteLine(string.Join(" ", _comPicture[_h]));
//    }
//  }

//  private static int[][] FinePicture(int H, int W, int[][] _picture)
//  {
//    int[][] _finePicture = new int[2 * H][];
//    for (int _h = 0; _h < H; _h++)
//    {
//      _finePicture[2 * _h] = new int[2 * W];
//      _finePicture[2 * _h + 1] = new int[2 * W];
//      for (int _w = 0; _w < W; _w++)
//      {
//        _finePicture[2 * _h][2 * _w] = _picture[_h][_w];
//        _finePicture[2 * _h][2 * _w + 1] = _picture[_h][_w];
//        _finePicture[2 * _h + 1][2 * _w] = _picture[_h][_w];
//        _finePicture[2 * _h + 1][2 * _w + 1] = _picture[_h][_w];
//      }
//    }
//    return _finePicture;
//  }

//  private static int[][] ReadPicture(int H)
//  {
//    int[][] _picture = new int[H][];
//    for (int i = 0; i < H; i++)
//    {
//      _picture[i] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    }
//    return _picture;
//  }
//}