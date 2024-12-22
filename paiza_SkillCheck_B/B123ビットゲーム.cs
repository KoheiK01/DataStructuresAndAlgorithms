//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1];
//    int[][] _ps = new int[N][];
//    for (int i = 0; i < N; i++)
//    {
//      _ps[i] = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    }
//    string[] _orders = new string[M];
//    int[][] _qs = new int[M][];
//    for (int i = 0; i < M; i++)
//    {
//      string[] _inputs = Console.ReadLine().Trim().Split();
//      _orders[i] = _inputs[0];
//      _qs[i] = _inputs.Skip(1).Select(int.Parse).ToArray();
//    }

//    for (int _order = 0; _order < M; _order++)
//    {
//      int[] _q = _qs[_order];
//      if (_orders[_order] == "a")
//      {
//        for (int _player = 0; _player < N; _player++)
//        {
//          int[] _p = _ps[_player];
//          _p[0] = _p[0] | _q[0];
//          _p[1] = _p[1] | _q[1];
//          _p[2] = _p[2] | _q[2];
//        }

//      }
//      else if (_orders[_order] == "b")
//      {
//        for (int _player = 0; _player < N; _player++)
//        {
//          int[] _p = _ps[_player];
//          _p[0] = _p[0] & _q[0];
//          _p[1] = _p[1] & _q[1];
//          _p[2] = _p[2] & _q[2];
//        }
//      }
//      else
//      {
//        for (int _player = 0; _player < N; _player++)
//        {
//          int[] _p = _ps[_player];
//          _p[0] = _p[0] ^ _q[0];
//          _p[1] = _p[1] ^ _q[1];
//          _p[2] = _p[2] ^ _q[2];
//        }
//      }
//    }

//    int _maxScore = 0;
//    int[] _scores = new int[N];
//    for (int i = 0; i < N; i++)
//    {
//      int _score = 100 * _ps[i][0] + 10 * _ps[i][1] + _ps[i][2];
//      if (_score > _maxScore)
//      {
//        _maxScore = _score;
//      }
//      _scores[i] = _score;
//    }
//    for (int i = 0; i < N; i++)
//    {
//      if (_scores[i] == _maxScore)
//      {
//        Console.WriteLine(i + 1);
//      }
//    }
//  }
//}