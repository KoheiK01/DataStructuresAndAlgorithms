//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 2 頂点間の最短経路 **********/
//    //int L, N, X, Y;
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //N = _firstLine[0]; X = _firstLine[1] - 1;
//    //L = _firstLine[2];
//    //Y = _firstLine[2] - 1;
//    //SortedSet<int>[] _g = CreateList(N);
//    //int[] _previous = MoveBFS(_g, N, X);
//    //int[] _distances = MoveBFS(_g, N, X);
//    //for (int _i = 0; _i < _distances.Length; _i++)
//    //{
//    //  if (_distances[_i] == L)
//    //  {
//    //    Console.WriteLine(_i + 1);
//    //  }
//    //}
//    //Console.WriteLine(_distances[Y]);
//    //int _index = Y;
//    //List<int> _ans = new List<int>();
//    //while (_index != X)
//    //{
//    //  _ans.Add(_index + 1);
//    //  _index = _previous[_index];
//    //}
//    //_ans.Add(_index + 1);
//    //_ans.Reverse();
//    //Console.WriteLine(string.Join("\n", _ans));

//    /********** 2 頂点間の距離 **********/
//    //int N, M, X, Y;
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //N = _firstLine[0]; M = _firstLine[1]; X = _firstLine[2] - 1; Y = _firstLine[3] - 1;
//    //SortedSet<int>[] _g = CreateList(N, M);
//    //ShowBFS(_g, N, X);
//    //int[] _distances = MoveBFS(_g, N, X);
//    //Console.WriteLine(_distances[Y]);
//  }

//  private static void ShowBFS(SortedSet<int>[] _g, int N, int X)
//  {
//    bool[] _visited = new bool[N];
//    Queue<int> _queue = new Queue<int>();
//    _queue.Enqueue(X);

//    while (_queue.Count > 0)
//    {
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        int _parent = _queue.Dequeue();
//        if (_visited[_parent]) { continue; }
//        Console.WriteLine(_parent + 1);
//        _visited[_parent] = true;
//        foreach (int _neighbor in _g[_parent])
//        {
//          _queue.Enqueue(_neighbor);
//        }
//      }
//    }
//  }

//  private static int[] MoveBFS(SortedSet<int>[] _g, int N, int X)
//  {
//    int[] _previous = Enumerable.Repeat(-1, N).ToArray();
//    int[] _distances = Enumerable.Repeat(-1, N).ToArray();
//    Queue<int> _queue = new Queue<int>();
//    _queue.Enqueue(X);
//    _distances[X] = 0;

//    while (_queue.Count > 0)
//    {
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        int _parent = _queue.Dequeue();
//        foreach (int _neighbor in _g[_parent])
//        {
//          if (_distances[_neighbor] != -1) { continue; }
//          _previous[_neighbor] = _parent;
//          _queue.Enqueue(_neighbor);
//          _distances[_neighbor] = _distances[_parent] + 1;
//        }
//      }
//    }
//    return _distances;
//  }

//  private static SortedSet<int>[] CreateList(int N)
//  {
//    SortedSet<int>[] _g = new SortedSet<int>[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _g[_i] = new SortedSet<int>();
//    }
//    for (int _i = 0; _i < N; _i++)
//    {
//      int[] _ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _a = _ab[0] - 1, _b = _ab[1] - 1;
//      _g[_a].Add(_b);
//      _g[_b].Add(_a);
//    }
//    return _g;
//  }

//  private static SortedSet<int>[] CreateList(int N, int M)
//  {
//    SortedSet<int>[] _g = new SortedSet<int>[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _g[_i] = new SortedSet<int>();
//    }
//    for (int _i = 0; _i < M; _i++)
//    {
//      int[] _ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _a = _ab[0] - 1, _b = _ab[1] - 1;
//      _g[_a].Add(_b);
//      _g[_b].Add(_a);
//    }
//    return _g;
//  }
//}
