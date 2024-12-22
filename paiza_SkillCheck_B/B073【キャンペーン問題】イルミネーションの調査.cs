//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1];
//    int[] A = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();


//    int Q = int.Parse(Console.ReadLine());
//    for (int _q = 0; _q < Q; _q++)
//    {
//      int[] _query = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _startIndex = _query[0] - 1;
//      int _endIndex = _query[1] - 1;
//      int _count = 0;
//      for (int _index = _startIndex; _index <= _endIndex; _index++)
//      {
//        _count += A[_index];
//      }
//      int _length = _endIndex - _startIndex + 1;
//      if (_count < M * _length)
//      {
//        int _totalAdd = M * _length - _count;
//        int _addPerTree = (int)Math.Ceiling((double)_totalAdd / _length);
//        for (int _index = _startIndex; _index <= _endIndex; _index++)
//        {
//          A[_index] += _addPerTree;
//        }
//      }
//    }

//    Console.WriteLine(string.Join(" ", A));
//  }
//}