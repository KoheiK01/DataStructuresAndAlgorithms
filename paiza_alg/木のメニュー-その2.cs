//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 二分探索木での値の検索 **************/
//    //STEP: 1 子の頂点
//    //int[] NKR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NKR[0], K = NKR[1], R = NKR[2];
//    //BinaryTreeNode[] _nodes = CreateBinaryTree(N);
//    //for (int _i = 0; _i < K; _i++)
//    //{
//    //  string[] _vlr = Console.ReadLine().Split();
//    //  int _v = int.Parse(_vlr[0]) - 1;
//    //  string _direction = _vlr[1];
//    //  switch (_direction)
//    //  {
//    //    case "L":
//    //      Console.WriteLine(_nodes[_v].Left == null ? "" : (_nodes[_v].Left.Data + 1).ToString());
//    //      break;
//    //    case "R":
//    //      Console.WriteLine(_nodes[_v].Right == null ? "" : (_nodes[_v].Right.Data + 1).ToString());
//    //      break;
//    //  }
//    //}

//    //STEP: 2 子の頂点
//    //int[] NKR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NKR[0], K = NKR[1], R = NKR[2];
//    //TreeNode[] _nodes = CreateTree(N);
//    //for (int _i = 0; _i < K; _i++)
//    //{
//    //  int[] _vl = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //  int _v = _vl[0] - 1;
//    //  int _l = _vl[1] - 1;
//    //  Console.WriteLine(_nodes[_v].Children[_l].Data + 1);
//    //}

//    //STEP: 3 完全二分木の管理
//    //int[] NKR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NKR[0], K = NKR[1], R = NKR[2];
//    //Dictionary<int, int> _location = new Dictionary<int, int>();
//    //int[] _binaryTree = new int[2 * N];
//    //_binaryTree[0] = R;
//    //_location.Add(R, 0);
//    //for (int _i = 0; _i < N - 1; _i++)
//    //{
//    //  string[] _ablr = Console.ReadLine().Trim().Split();
//    //  int _a = int.Parse(_ablr[0]);
//    //  int _b = int.Parse(_ablr[1]);
//    //  string _lr = _ablr[2];
//    //  switch (_lr)
//    //  {
//    //    case "L":
//    //      _location.Add(_b, 2 * _location[_a] + 1);
//    //      break;
//    //    case "R":
//    //      _location.Add(_b, 2 * _location[_a] + 2);
//    //      break;
//    //  }
//    //  _binaryTree[_location[_b]] = _b;
//    //}
//    //for (int _i = 0; _i < K; _i++)
//    //{
//    //  string[] vlr = Console.ReadLine().Trim().Split();
//    //  int v = int.Parse(vlr[0]);
//    //  string _lr = vlr[1];
//    //  switch (_lr)
//    //  {
//    //    case "L":
//    //      Console.WriteLine(_binaryTree[2 * _location[v] + 1]);
//    //      break;
//    //    case "R":
//    //      Console.WriteLine(_binaryTree[2 * _location[v] + 2]);
//    //      break;
//    //  }
//    //}

//    //STEP: 4 二分探索木の判定
//    //int[] NR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NR[0], R = NR[1];
//    //for (int _i = 0; _i < N - 1; _i++)
//    //{
//    //  string[] _ablr = Console.ReadLine().Trim().Split();
//    //  int _a = int.Parse(_ablr[0]);
//    //  int _b = int.Parse(_ablr[1]);
//    //  string _lr = _ablr[2];
//    //  switch (_lr)
//    //  {
//    //    case "L":
//    //      if(_a < _b)
//    //      {
//    //        Console.WriteLine("NO");
//    //        return;
//    //      }
//    //      break;
//    //    case "R":
//    //      if(_a > _b)
//    //      {
//    //        Console.WriteLine("NO");
//    //        return;
//    //      }
//    //      break;
//    //  }
//    //}
//    //Console.WriteLine("YES");

//    //STEP: 5 二分探索木への値の追加
//    //int[] NR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NR[0], R = NR[1];
//    //int[] _binaryTree = Enumerable.Repeat(-1, (int)Math.Pow(2, 19) - 1).ToArray();
//    //Dictionary<int, int> _location = new Dictionary<int, int> { { R, 0 } };
//    //_binaryTree[0] = R;
//    //for (int _i = 0; _i < N - 1; _i++)
//    //{
//    //  string[] _ablr = Console.ReadLine().Trim().Split();
//    //  int _a = int.Parse(_ablr[0]);
//    //  int _b = int.Parse(_ablr[1]);
//    //  string _lr = _ablr[2];
//    //  switch (_lr)
//    //  {
//    //    case "L":
//    //      _location.Add(_b, 2 * _location[_a] + 1);
//    //      break;
//    //    case "R":
//    //      _location.Add(_b, 2 * _location[_a] + 2);
//    //      break;
//    //  }
//    //  _binaryTree[_location[_b]] = _b;
//    //}
//    //int V = int.Parse(Console.ReadLine());
//    //int _index = 0;
//    //int P = 0;
//    //string _direction = "";
//    //while (_binaryTree[_index] != -1)
//    //{
//    //  P = _binaryTree[_index];
//    //  if (V < _binaryTree[_index])
//    //  {
//    //    _direction = "L";
//    //    _index = 2 * _index + 1;
//    //  }
//    //  else
//    //  {
//    //    _direction = "R";
//    //    _index = 2 * _index + 2;
//    //  }
//    //}
//    //Console.WriteLine(P);
//    //Console.WriteLine(_direction);

//    //FINAL問題 二分探索木での値の検索
//    //int[] NKR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NKR[0], K = NKR[1], R = NKR[2];
//    //int[] _binaryTree = Enumerable.Repeat(-1, (int)Math.Pow(2, 19) - 1).ToArray();
//    //_binaryTree[0] = R;
//    //Dictionary<int, int> _location = new Dictionary<int, int> { { R, 0 } };
//    //for (int _i = 0; _i < N - 1; _i++)
//    //{
//    //  int[] _ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //  int _a = _ab[0], _b = _ab[1];
//    //  if (_a > _b)
//    //  {
//    //    _location.Add(_b, 2 * _location[_a] + 1);
//    //  }
//    //  else
//    //  {
//    //    _location.Add(_b, 2 * _location[_a] + 2);
//    //  }
//    //  _binaryTree[_location[_b]] = _b;
//    //}
//    //for (int _i = 0; _i < K; _i++)
//    //{
//    //  int _query = int.Parse(Console.ReadLine());
//    //  string _ans = "No";
//    //  int _index = 0;
//    //  while (_binaryTree[_index] != -1)
//    //  {
//    //    if (_binaryTree[_index] == _query)
//    //    {
//    //      _ans = "Yes";
//    //    }
//    //    if (_query < _binaryTree[_index])
//    //    {
//    //      _index = _index * 2 + 1;
//    //    }
//    //    else
//    //    {
//    //      _index = _index * 2 + 2;
//    //    }
//    //  }
//    //  Console.WriteLine(_ans);
//    //}
//  }

//  private static BinaryTreeNode[] CreateBinaryTree(int N)
//  {
//    BinaryTreeNode[] _nodes = new BinaryTreeNode[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _nodes[_i] = new BinaryTreeNode(_i);
//    }

//    for (int _i = 0; _i < N - 1; _i++)
//    {
//      string[] _abLR = Console.ReadLine().Trim().Split();
//      int _a = int.Parse(_abLR[0]) - 1;
//      int _b = int.Parse(_abLR[1]) - 1;
//      string _direction = _abLR[2];
//      switch (_direction)
//      {
//        case "L":
//          _nodes[_a].Left = _nodes[_b];
//          break;
//        case "R":
//          _nodes[_a].Right = _nodes[_b];
//          break;
//      }
//    }
//    return _nodes;
//  }

//  private static TreeNode[] CreateTree(int N)
//  {
//    TreeNode[] _nodes = new TreeNode[N];
//    for (int _i = 0; _i < N; _i++)
//    {
//      _nodes[_i] = new TreeNode(_i);
//    }

//    for (int _i = 0; _i < N - 1; _i++)
//    {
//      int[] _ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int _a = _ab[0] - 1;
//      int _b = _ab[1] - 1;
//      _nodes[_a].Children.Add(_nodes[_b]);
//    }
//    return _nodes;
//  }
//}

//public class BinaryTreeNode
//{
//  public int Data;
//  public BinaryTreeNode Left = null;
//  public BinaryTreeNode Right = null;

//  public BinaryTreeNode(int _data)
//  {
//    Data = _data;
//  }
//}

//public class TreeNode
//{
//  public int Data;
//  public List<TreeNode> Children = new List<TreeNode>();

//  public TreeNode(int _data)
//  {
//    Data = _data;
//  }
//}
