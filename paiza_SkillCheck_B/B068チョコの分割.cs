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
//    string[] _ans = new string[H];
//    for (int _row = 0; _row < H; _row++)
//    {
//      int[] _sugars = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int[] _sums = new int[W];
//      _sums[0] = _sugars[0];
//      for (int _col = 1; _col < W; _col++)
//      {
//        _sums[_col] = _sugars[_col] + _sums[_col - 1];
//      }
//      int _sum = _sugars.Sum();
//      for (int _col = 0; _col < W - 1; _col++)
//      {
//        int _alice = _sums[_col];
//        int _bob = _sum - _alice;
//        if (_alice == _bob)
//        {
//          _ans[_row] = string.Concat(Enumerable.Repeat("A", _col + 1));
//          _ans[_row] += string.Concat(Enumerable.Repeat("B", W - _col - 1));
//          break;
//        }
//        if (_alice > _bob)
//        {
//          Console.WriteLine("No");
//          return;
//        }
//      }
//    }

//    Console.WriteLine("Yes");
//    for (int _h = 0; _h < H; _h++)
//    {
//      Console.WriteLine(_ans[_h]);
//    }
//  }
//}