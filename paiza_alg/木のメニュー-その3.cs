//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 根付き木の根の変更 **************/
//    //STEP: 1 距離が X の頂点
//    //int[] NAB = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NAB[0], A = NAB[1] - 1, X = NAB[2];
//    //Queue<int> Q = new Queue<int>();
//    //Q.Enqueue(A);
//    //SortedSet<int>[] _g = CreateList(N);
//    //int[] _previous = Enumerable.Repeat(-1, N).ToArray();
//    //_previous[A] = 0;
//    //while (Q.Count > 0)
//    //{
//    //  int _a = Q.Dequeue();
//    //  foreach (int _neighbor in _g[_a])
//    //  {
//    //    if (_previous[_neighbor] == -1)
//    //    {
//    //      _previous[_neighbor] = _previous[_a] + 1;
//    //      Q.Enqueue(_neighbor);
//    //    }
//    //  }
//    //}
//    //for (int _i = 0; _i < N; _i++)
//    //{
//    //  if (_previous[_i] == X)
//    //  {
//    //    Console.WriteLine(_i + 1);
//    //  }
//    //}

//    //STEP: 2 二頂点間の経路
//    //int[] NAB = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NAB[0], A = NAB[1] - 1, B = NAB[2] - 1;
//    //Queue<int> Q = new Queue<int>();
//    //Q.Enqueue(A);
//    //SortedSet<int>[] _g = CreateList(N);
//    //int[] _previous = Enumerable.Repeat(-1, N).ToArray();
//    //_previous[A] = -2;
//    //while (Q.Count > 0)
//    //{
//    //  int _a = Q.Dequeue();
//    //  foreach (int _neighbor in _g[_a])
//    //  {
//    //    if (_previous[_neighbor] == -1)
//    //    {
//    //      _previous[_neighbor] = _a;
//    //      Q.Enqueue(_neighbor);
//    //    }
//    //  }
//    //}
//    //List<int> _ans = new List<int>();
//    //int _index = B;
//    //while (_previous[_index] != -2)
//    //{
//    //  _ans.Add(_index + 1);
//    //  _index = _previous[_index];
//    //}
//    //_ans.Add(A + 1);
//    //_ans.Reverse();
//    //Console.WriteLine(string.Join("\n", _ans));

//    //STEP: 3 木の直径
//    //int N = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] _g = CreateList(N);
//    //int[] _lenFrom0 = CalLen(_g, 0, N);
//    //int _root = Array.IndexOf(_lenFrom0, _lenFrom0.Max());
//    //int[] _lenFromRoot = CalLen(_g, _root, N);
//    //Console.Write(_lenFromRoot.Max());

//    //STEP: 4 木の同型判定
//    //int N1 = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] _g1 = CreateList(N1);
//    //int N2 = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] _g2 = CreateList(N2);
//    //if (N1 != N2)
//    //{
//    //  Console.WriteLine("NO");
//    //}
//    //else
//    //{
//    //  List<int[]> _permute = new List<int[]>();
//    //  List<int> _target = Enumerable.Range(0, N2).ToList();
//    //  Permute(_permute, _target, 0);
//    //  foreach (int[] _p in _permute)
//    //  {
//    //    bool _check = true;
//    //    for (int _i = 0; _i < N2; _i++)
//    //    {
//    //      if (_g1[_i].Count != _g2[_p[_i]].Count)
//    //      {
//    //        _check = false;
//    //        break;
//    //      }
//    //    }
//    //    if (_check)
//    //    {
//    //      Console.WriteLine("YES");
//    //      return;
//    //    }
//    //  }
//    //  Console.WriteLine("NO");
//    //}

//    //FINAL問題 根付き木の根の変更
//    //int[] NR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NR[0], R = NR[1];
//    //SortedSet<int>[] _g = CreateList(N);

//    //int[] _kr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int K = _kr[0], r = _kr[1] - 1;
//    //int[] _parents = ChangeParents(r, _g, N);
//    //for (int _i = 0; _i < K; _i++)
//    //{
//    //  int v = int.Parse(Console.ReadLine()) - 1;
//    //  Console.WriteLine(_parents[v] + 1);
//    //}
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

//  private static int[] CalLen(SortedSet<int>[] _g, int _fromIndex, int N)
//  {
//    int[] _len = Enumerable.Repeat(-1, N).ToArray();
//    _len[_fromIndex] = 0;
//    Queue<int> _q = new Queue<int>();
//    _q.Enqueue(_fromIndex);
//    while (_q.Count > 0)
//    {
//      int _a = _q.Dequeue();
//      foreach (var _neighbor in _g[_a])
//      {
//        if (_len[_neighbor] == -1)
//        {
//          _len[_neighbor] = _len[_a] + 1;
//          _q.Enqueue(_neighbor);
//        }
//      }
//    }

//    return _len;
//  }

//  private static void Permute(List<int[]> _permute, List<int> _tempPermute, int _start)
//  {
//    for (int _i = _start; _i < _tempPermute.Count; _i++)
//    {
//      Swap(_tempPermute, _i, _start);
//      Permute(_permute, _tempPermute, _start + 1);
//      Swap(_tempPermute, _start, _i);
//    }

//    if (_start == _tempPermute.Count - 1)
//    {
//      _permute.Add(_tempPermute.ToArray());
//    }
//  }
//  private static void Swap(List<int> _list, int _i, int _j)
//  {
//    int _temp = _list[_i];
//    _list[_i] = _list[_j];
//    _list[_j] = _temp;
//  }

//  private static int[] ChangeParents(int _root, SortedSet<int>[] _g, int N)
//  {
//    int[] _parents = Enumerable.Repeat(-2, N).ToArray();
//    _parents[_root] = -1;
//    Queue<int> _q = new Queue<int>();
//    _q.Enqueue(_root);
//    while (_q.Count > 0)
//    {
//      int _parent = _q.Dequeue();
//      foreach (var _child in _g[_parent])
//      {
//        if (_parents[_child] == -2)
//        {
//          _parents[_child] = _parent;
//          _q.Enqueue(_child);
//        }
//      }
//    }
//    return _parents;
//  }
//}
