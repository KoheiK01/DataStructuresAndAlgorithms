//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1];
//    int[] _harderCounts = new int[N];
//    List<int>[] _harderList = new List<int>[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _harderList[_i] = new List<int>();
//    }
//    for (int _m = 0; _m < M; _m++)
//    {
//      int[] _ints = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _harder = _ints[0] - 1;
//      int _softer = _ints[1] - 1;
//      _harderCounts[_harder]++;
//      _harderList[_softer].Add(_harder);
//    }
//    List<int> _ans = new List<int>();
//    Queue<int> _queue = new Queue<int>();
//    for (int _i = 0; _i < N; _i++)
//    {
//      if (_harderCounts[_i] == 0)
//      {
//        _queue.Enqueue(_i);
//      }
//    }
//    while (_queue.Count == 1)
//    {
//      int _min = _queue.Dequeue();
//      _ans.Add(_min);
//      foreach (var _harder in _harderList[_min])
//      {
//        _harderCounts[_harder]--;
//        if (_harderCounts[_harder] == 0)
//        {
//          _queue.Enqueue(_harder);
//        }
//      }
//    }

//    if (_ans.Count == N)
//    {
//      _ans.Reverse();
//      Console.WriteLine(string.Join(" ", _ans.Select(_i => _i = _i + 1).ToList()));
//    }
//    else
//    {
//      Console.WriteLine(-1);
//    }
//  }
//}
