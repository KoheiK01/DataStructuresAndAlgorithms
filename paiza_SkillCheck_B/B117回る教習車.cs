//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());
//    int[] _counts = new int[N];
//    List<int> _positions = new List<int>();
//    for (int i = 0; i < N; i++)
//    {
//      _positions.Add(int.Parse(Console.ReadLine()));
//    }
//    for (int _car = 1; _car <= N; _car++)
//    {
//      int _index = _positions.IndexOf(_car);
//      for (int _drive = 0; _drive < _index; _drive++)
//      {
//        _counts[_positions[_drive] - 1]++;
//        _positions.Add(_positions[_drive]);
//      }
//      _positions.RemoveRange(0, _index + 1);
//    }

//    Console.WriteLine(_counts[N - 1]);
//  }
//}