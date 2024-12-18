//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 連結成分の個数 **********/
//    //STEP: 1 グラフの深さ優先探索
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = _firstLine[0], M = _firstLine[1], X = _firstLine[2] - 1;
//    //var _g = CreateList(N, M);
//    //bool[] _visited = new bool[N];
//    //ShowDfs(_g, _visited, X);

//    //STEP: 2 二部グラフ判定
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = _firstLine[0], M = _firstLine[1];
//    //var _g = CreateList(N, M);
//    //int[] _colors = Enumerable.Repeat(-1, N).ToArray();
//    //for (int _node = 0; _node < N; _node++)
//    //{
//    //  if (_colors[_node] == -1)
//    //  {
//    //    if (!ChangeColorsByDfs(_g, _colors, 0, _node))
//    //    {
//    //      Console.WriteLine("No");
//    //      return;
//    //    }
//    //  }
//    //}
//    //Console.WriteLine("Yes");

//    //FINAL問題 連結成分の個数
//    //int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = _firstLine[0], M = _firstLine[1];
//    //var _g = CreateList(N, M);
//    //bool[] _visited = new bool[N];
//    //int _ans = 0;
//    //for (int _node = 0; _node < N; _node++)
//    //{
//    //  if (!_visited[_node])
//    //  {
//    //    _ans++;
//    //    Dfs(_g, _visited, _node);
//    //  }
//    //}
//    //Console.WriteLine(_ans);
//  }

//  private static void Dfs(SortedSet<int>[] _g, bool[] _visited, int _node)
//  {
//    _visited[_node] = true;

//    foreach (int _neighbor in _g[_node])
//    {
//      if (_visited[_neighbor]) { continue; }
//      Dfs(_g, _visited, _neighbor);
//    }
//  }

//  private static bool ChangeColorsByDfs(SortedSet<int>[] _g, int[] _colors, int _color, int _node)
//  {
//    _colors[_node] = _color;

//    foreach (var _neighbor in _g[_node])
//    {
//      if (_colors[_neighbor] == -1)
//      {
//        if (!ChangeColorsByDfs(_g, _colors, 1 - _color, _neighbor))
//        {
//          return false;
//        }
//      }
//      else if (_colors[_neighbor] == _color)
//      {
//        return false;
//      }
//    }
//    return true;
//  }

//  private static void ShowDfs(SortedSet<int>[] _g, bool[] _visited, int _now)
//  {
//    Console.WriteLine(_now + 1);
//    _visited[_now] = true;

//    foreach (var _neighbor in _g[_now])
//    {
//      if (_visited[_neighbor]) { continue; }
//      ShowDfs(_g, _visited, _neighbor);
//    }
//  }

//  private static SortedSet<int>[] CreateList(int N, int M)
//  {
//    var _g = new SortedSet<int>[N];
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
