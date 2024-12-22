//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());
//    int _num1, _num2, _num3;
//    int _p1, _p2, _p3;
//    int[] _sell1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    _num1 = _sell1[0]; _p1 = _sell1[1];
//    int[] _sell2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    _num2 = _sell2[0]; _p2 = _sell2[1];
//    int[] _sell3 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    _num3 = _sell3[0]; _p3 = _sell3[1];

//    int[] _dp = Enumerable.Repeat(int.MaxValue, N + _num3).ToArray();
//    _dp[0] = 0;

//    for (int _num = 0; _num < N + _num3; _num++)
//    {
//      if (_num1 <= _num && _dp[_num - _num1] != int.MaxValue)
//      {
//        _dp[_num] = Math.Min(_dp[_num], _dp[_num - _num1] + _p1);
//      }
//      if (_num2 <= _num && _dp[_num - _num2] != int.MaxValue)
//      {
//        _dp[_num] = Math.Min(_dp[_num], _dp[_num - _num2] + _p2);
//      }
//      if (_num3 <= _num && _dp[_num - _num3] != int.MaxValue)
//      {
//        _dp[_num] = Math.Min(_dp[_num], _dp[_num - _num3] + _p3);
//      }
//    }

//    int _ans = _dp.Skip(N).Min();
//    Console.WriteLine(_ans);
//  }
//}