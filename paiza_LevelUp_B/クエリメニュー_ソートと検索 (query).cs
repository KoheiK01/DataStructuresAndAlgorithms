//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** ソートと検索 (query) **********/
//    //STEP: 1 指定の位置への要素の追加
//    //int[] NKQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NKQ[0], K = NKQ[1], Q = NKQ[2];
//    //List<int> list = new List<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.Add(int.Parse(Console.ReadLine()));
//    //}
//    //list.Insert(K, Q);
//    //Console.WriteLine(string.Join("\n", list));

//    //STEP: 2 指定要素の検索
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //List<int> list = new List<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.Add(int.Parse(Console.ReadLine()));
//    //}
//    //Console.WriteLine(list.Contains(K) ? "YES" : "NO");

//    //STEP: 3 指定要素の検索 (query)
//    //int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NQ[0], Q = NQ[1];
//    //SortedSet<string> set = new SortedSet<string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  set.Add(Console.ReadLine());
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  string K = Console.ReadLine();
//    //  Console.WriteLine(set.Contains(K) ? "YES" : "NO");
//    //}

//    //STEP: 4 先頭の要素の削除
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> list = new List<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.Add(int.Parse(Console.ReadLine()));
//    //}
//    //list.RemoveAt(0);
//    //Console.WriteLine(string.Join("\n", list));

//    //STEP: 5 先頭の要素の削除(query)
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Queue<int> queue = new Queue<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  queue.Enqueue(int.Parse(Console.ReadLine()));
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string order = Console.ReadLine();
//    //  if(queue.Count == 0) continue;
//    //  switch(order)
//    //  {
//    //    case "pop":
//    //      queue.Dequeue();
//    //      break;
//    //    case "show":
//    //      Console.WriteLine(string.Join("\n", queue));
//    //      break;
//    //  }
//    //}

//    //STEP: 6 連想配列
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Dictionary<int, string> _pairs = new Dictionary<int, string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split();
//    //  int num = int.Parse(line[0]);
//    //  string id = line[1];
//    //  _pairs.Add(num, id);
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int num = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(_pairs[num]);
//    //}

//    //STEP: 7 連想配列(query)
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Dictionary<int, string> _pairs = new Dictionary<int, string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split();
//    //  int num = int.Parse(line[0]);
//    //  string id = line[1];
//    //  _pairs.Add(num, id);
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string order = _strings[0];
//    //  int num = int.Parse(_strings[1]);
//    //  switch (order)
//    //  {
//    //    case "join":
//    //      string id = _strings[2];
//    //      _pairs.Add(num, id);
//    //      break;

//    //    case "leave":
//    //      _pairs.Remove(num);
//    //      break;

//    //    case "call":
//    //      Console.WriteLine(_pairs[num]);
//    //      break;
//    //  }
//    //}

//    //STEP: 8 ソートと検索
//    //int[] NXP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NXP[0], X = NXP[1], P = NXP[2];
//    //List<int> list = new List<int> { P, X };
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.Add(int.Parse(Console.ReadLine()));
//    //}
//    //list = list.OrderBy(x => x).ToList();
//    //Console.WriteLine(list.IndexOf(P) + 1);

//    //FINAL問題 ソートと検索(query)
//    //int[] NKP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NKP[0], K = NKP[1], P = NKP[2];
//    //List<int> list = new List<int> { P };
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.Add(int.Parse(Console.ReadLine()));
//    //}
//    //list = list.OrderBy(x => x).ToList();
//    //int ranking = list.IndexOf(P) + 1;
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string _event = _strings[0];
//    //  switch (_event)
//    //  {
//    //    case "join":
//    //      int height = int.Parse(_strings[1]);
//    //      if (height < P)
//    //      {
//    //        ranking++;
//    //      }
//    //      break;

//    //    case "sorting":
//    //      Console.WriteLine(ranking);
//    //      break;
//    //  }
//    //}
//  }
//}