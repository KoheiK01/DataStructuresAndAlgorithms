//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int N = int.Parse(Console.ReadLine());
//    int[] _weights = new int[N];
//    for (int i = 0; i < N; i++)
//    {
//      _weights[i] = int.Parse(Console.ReadLine());
//    }
//    int M = int.Parse(Console.ReadLine());
//    int[] _maxWeights = new int[M];
//    int[] _costs = new int[M];
//    for (int i = 0; i < M; i++)
//    {
//      int[] _inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      _maxWeights[i] = _inputs[0];
//      _costs[i] = _inputs[1];
//    }

//    int[] _dp = Enumerable.Repeat(int.MaxValue, N + 1).ToArray();
//    _dp[0] = 0;
//    for (int _item = 0; _item < N; _item++)
//    {
//      for (int _method = 0; _method < M; _method++)
//      {
//        int _curWeights = 0;
//        for (int _item2 = _item; _item2 < N; _item2++)
//        {
//          _curWeights += _weights[_item2];
//          if (_curWeights > _maxWeights[_method])
//          {
//            break;
//          }

//          _dp[_item2 + 1] = Math.Min(_dp[_item2 + 1], _dp[_item] + _costs[_method]);
//        }

//      }
//    }

//    Console.WriteLine(_dp.Last());
//  }
//}
