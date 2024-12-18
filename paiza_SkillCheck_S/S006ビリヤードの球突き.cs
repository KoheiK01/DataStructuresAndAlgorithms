//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int W = _firstLine[0], H = _firstLine[1];
//    int _sx = _firstLine[2], _sy = _firstLine[3];
//    int _r = _firstLine[4];
//    int _theta = _firstLine[5];
//    int L = _firstLine[6];

//    double LX = _sx + L * Math.Cos(_theta * Math.PI / 180);
//    double LY = _sy + L * Math.Sin(_theta * Math.PI / 180);

//    double _endx = CalEndPostion(LX, W, _r);
//    double _endy = CalEndPostion(LY, H, _r);

//    Console.WriteLine($"{_endx} {_endy}");
//  }

//  private static double CalEndPostion(double _distance, int _size, int _r)
//  {
//    int _bound = (int)Math.Floor((_distance - _r) / (_size - 2 * _r));
//    double _base = _distance - (_size - 2 * _r) * _bound;
//    if (_bound % 2 == 0)
//    {
//      return _base;
//    }
//    else
//    {
//      return _size - _base;
//    }
//  }
//}
