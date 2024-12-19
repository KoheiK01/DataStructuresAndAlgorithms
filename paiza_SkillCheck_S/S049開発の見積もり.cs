//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], X = _firstLine[1], F = _firstLine[2], S = _firstLine[3];

//    int _maxTime = (N - 1) * 4 + 1;
//    int _maxSpped = X;

//    int[][] _dp = new int[_maxTime + 1][];
//    for (int i = 0; i <= _maxTime; i++)
//    {
//      _dp[i] = Enumerable.Repeat(-1, _maxSpped + 1).ToArray();
//    }

//    _dp[0][_maxSpped] = 0;
//    for (int _time = 0; _time <= _maxTime; _time++)
//    {
//      for (int _spped = 0; _spped <= _maxSpped; _spped++)
//      {
//        if (_dp[_time][_spped] == -1 || _dp[_time][_spped] >= N) { continue; }

//        int _nextTime = _time + 1;
//        int _nextSpped = Math.Max(0, _spped - F);
//        int _codeStep = _dp[_time][_spped] + _spped;

//        if (_nextTime <= _maxTime)
//        {
//          _dp[_nextTime][_nextSpped] = Math.Max(_dp[_nextTime][_nextSpped], _codeStep);
//        }

//        _nextTime = _time + 3;
//        _nextSpped = Math.Min(_spped + S, _maxSpped);
//        if (_nextTime <= _maxTime)
//        {
//          _dp[_nextTime][_nextSpped] = Math.Max(_dp[_nextTime][_nextSpped], _dp[_time][_spped]);
//        }
//      }
//    }

//    for (int _time = 0; _time <= _maxTime; _time++)
//    {
//      for (int _spped = 0; _spped <= _maxSpped; _spped++)
//      {
//        if (_dp[_time][_spped] >= N)
//        {
//          Console.WriteLine(_time);
//          return;
//        }
//      }
//    }
//  }
//}
