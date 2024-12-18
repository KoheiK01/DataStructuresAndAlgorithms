//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 1 頂点の移動 **********/
//    //STEP: 1 木の深さ優先探索
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = _firstLine[0], _root = _firstLine[1] - 1;
//    //SortedSet<int>[] _g = CreateList(N);
//    //bool[] _visited = new bool[N];
//    //ShowTreeDfs(_g, _root, _visited);

//    //FINAL問題 1 頂点の移動
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = _firstLine[0], X = _firstLine[1] - 1, Y = _firstLine[2] - 1;
//    //SortedSet<int>[] _g = CreateList(N);
//    //bool[] _visited = new bool[N];
//    //(bool _finded, int _dfsCount) = MoveTreeDfs(_g, X, Y, _visited);
//    //int _bfsCount = MoveTreeBFS(_g, N, X, Y);
//    //if (_dfsCount < _bfsCount)
//    //{
//    //  Console.WriteLine("dfs");
//    //}
//    //else if (_dfsCount == _bfsCount)
//    //{
//    //  Console.WriteLine("same");
//    //}
//    //else
//    //{
//    //  Console.WriteLine("bfs");
//    //}
//  }


//  private static (bool found, int visitCount) MoveTreeDfs(SortedSet<int>[] _g, int _parent, int _wanted, bool[] _visited)
//  {
//    _visited[_parent] = true;
//    int _visitCount = 1;

//    if (_parent == _wanted)
//    {
//      return (true, _visitCount);
//    }

//    foreach (var _child in _g[_parent])
//    {
//      if (_visited[_child]) { continue; }
//      (bool _found, int _childCount) = MoveTreeDfs(_g, _child, _wanted, _visited);
//      _visitCount += _childCount;
//      if (_found)
//      {
//        return (true, _visitCount);
//      }
//    }
//    return (false, _visitCount);
//  }

//  private static int MoveTreeBFS(SortedSet<int>[] _g, int N, int _root, int _wanted)
//  {
//    bool[] _visited = new bool[N];
//    int _visitedCount = 0;
//    Queue<int> _queue = new Queue<int>();

//    _visited[_root] = true;
//    _visitedCount++;
//    if (_root == _wanted)
//    {
//      return _visitedCount;
//    }
//    _queue.Enqueue(_root);

//    while (_queue.Count > 0)
//    {
//      int _queueCount = _queue.Count;
//      for (int _i = 0; _i < _queueCount; _i++)
//      {
//        int _parent = _queue.Dequeue();
//        foreach (int _child in _g[_parent])
//        {
//          if (_visited[_child]) { continue; }
//          _visited[_child] = true;
//          _visitedCount++;
//          if (_child == _wanted)
//          {
//            return _visitedCount;
//          }
//          _queue.Enqueue(_child);
//        }
//      }
//    }
//    return -1;
//  }


//  private static SortedSet<int>[] CreateList(int N)
//  {
//    SortedSet<int>[] _g = new SortedSet<int>[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _g[_i] = new SortedSet<int>();
//    }
//    for (int _i = 0; _i < N - 1; _i++)
//    {
//      int[] _ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _a = _ab[0] - 1, _b = _ab[1] - 1;
//      _g[_a].Add(_b);
//      _g[_b].Add(_a);
//    }
//    return _g;
//  }
//}
