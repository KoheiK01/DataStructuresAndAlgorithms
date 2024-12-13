//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 三角形を作る **************/
//    //STEP: 1 木の入力の受け取り（隣接行列）
//    //int N = int.Parse(Console.ReadLine());
//    //bool[,] g = new bool[N, N];
//    //CreateMatrix(g, N);
//    //for (int j = 0; j < N; j++)
//    //{
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    Console.Write(j == N - 1 ? g[j, j] + "\n" : g[j, j] + " ");
//    //  }
//    //}

//    //STEP: 2 木の入力の受け取り（隣接リスト）
//    //int N = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] g = new SortedSet<int>[N];
//    //CreateList(g, N);
//    //for (int j = 0; j < N; j++)
//    //{
//    //  Console.WriteLine(string.Join(" ", g[j]));
//    //}

//    //STEP: 3 辺の有無の判定
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //bool[,] g = new bool[N, N];
//    //CreateMatrix(g, N);
//    //for (int j = 0; j < K; j++)
//    //{
//    //  int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int qa = query[0], qb = query[1];
//    //  Console.WriteLine(g[qa - 1, qb - 1] ? "YES" : "NO");
//    //}

//    //STEP: 4 葉の判定
//    //int N = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] g = new SortedSet<int>[N];
//    //CreateList(g, N);
//    //List<int> ans = new List<int>();
//    //for (int j = 0; j < N; j++)
//    //{
//    //  if (g[j].Count == 1)
//    //  {
//    //    ans.Add(j + 1);
//    //  }
//    //}
//    //Console.WriteLine(string.Join("\n", ans));

//    //STEP: 5 木の中心
//    //int N = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] g = new SortedSet<int>[N];
//    //CreateList(g, N);

//    //Queue<int> leaves = new Queue<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  if (g[i].Count == 1)
//    //    leaves.Enqueue(i);
//    //}

//    //int remainingNodes = N;
//    //while (remainingNodes > 2)
//    //{
//    //  int leafCount = leaves.Count;
//    //  remainingNodes -= leafCount;

//    //  for (int i = 0; i < leafCount; i++)
//    //  {
//    //    int leaf = leaves.Dequeue();
//    //    foreach (int queue in g[leaf])
//    //    {
//    //      g[queue].Remove(leaf);
//    //      if (g[queue].Count == 1)
//    //        leaves.Enqueue(queue);
//    //    }
//    //  }
//    //}

//    //List<int> centers = leaves.Select(i => i += 1).ToList();
//    //centers.Sort();
//    //Console.WriteLine(string.Join("\n", centers));

//    //FINAL問題 三角形を作る
//    //int N = int.Parse(Console.ReadLine());
//    //SortedSet<int>[] g = new SortedSet<int>[N];
//    //CreateList(g, N);
//    //int line = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  if (g[i].Count >= 2)
//    //  {
//    //    line += g[i].Count * (g[i].Count - 1) / 2;
//    //  }
//    //}
//    //Console.WriteLine(line % 2 == 0 ? "erik" : "paiza");

//    /********** 山登り **************/
//    //STEP: 1 子の頂点
//    //STEP: 2 親の頂点
//    //int[] NKR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NKR[0], K = NKR[1], R = NKR[2];
//    //Dictionary<int, int> queue = new Dictionary<int, int>();
//    //Dictionary<int, List<int>> childrenList = new Dictionary<int, List<int>>();
//    //for (int i = 0; i < N - 1; i++)
//    //{
//    //  int[] ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //  int a = ab[0], b = ab[1];
//    //  queue.Add(b, a);
//    //  if (childrenList.ContainsKey(a)) { childrenList[a].Add(b); }
//    //  else { childrenList.Add(a, new List<int> { b }); }
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int v = int.Parse(Console.ReadLine());
//    //  if (childrenList.ContainsKey(v))
//    //  {
//    //    childrenList[v].Sort();
//    //    Console.WriteLine(string.Join(" ", childrenList[v]));
//    //  }
//    //  if (queue.ContainsKey(v)) { Console.WriteLine(queue[v]); }
//    //  else { Console.WriteLine(); }
//    //}

//    //STEP: 3 ヒープの判定
//    //int[] NR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NR[0], R = NR[1];
//    //for (int i = 0; i < N - 1; i++)
//    //{
//    //  int[] ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //  int a = ab[0], b = ab[1];
//    //  if (a < b)
//    //  {
//    //    Console.WriteLine("NO");
//    //    return;
//    //  }
//    //}
//    //Console.WriteLine("YES");

//    //STEP: 4 頂点の高さ
//    //int[] NR = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NR[0], R = NR[1] - 1;
//    //SortedSet<int>[] g;
//    //List<(int a, int b)> saveab = new List<(int a, int b)>();
//    //(g, saveab) = CreateList(N);
//    //int[] depth = CalDepth(g, R, N);

//    //for (int i = 0; i < saveab.Count; i++)
//    //{
//    //  int a = saveab[i].a;
//    //  int b = saveab[i].b;
//    //  Console.WriteLine(depth[a] > depth[b] ? "B" : "A");
//    //}

//    //FINAL問題 山登り
//    //int[] NTSCD = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    //int N = NTSCD[0], T = NTSCD[1] - 1, S = NTSCD[2] - 1, C = NTSCD[3], D = NTSCD[4];
//    //SortedSet<int>[] g = new SortedSet<int>[N];
//    //CreateList(g, N);
//    //int[] depthFromTop = CalDepth(g, T, N);
//    //int[] depthFromStart = CalDepth(g, S, N);
//    //int up = C - D;
//    //int nowDepth = depthFromTop[S] - up;
//    //int maxDistance = C + D;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  if (depthFromTop[i] == nowDepth && depthFromStart[i] <= maxDistance)
//    //  {
//    //    Console.WriteLine(i + 1);
//    //  }
//    //}
//  }

//  private static void CreateMatrix(bool[,] g, int N)
//  {
//    for (int i = 0; i < N - 1; i++)
//    {
//      int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      int a = ab[0], b = ab[1];
//      g[a - 1, b - 1] = true;
//      g[b - 1, a - 1] = true;
//    }
//  }

//  private static void CreateList(SortedSet<int>[] g, int N)
//  {
//    for (int i = 0; i < N; i++)
//    {
//      g[i] = new SortedSet<int>();
//    }
//    for (int i = 0; i < N - 1; i++)
//    {
//      int[] ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int a = ab[0] - 1, b = ab[1] - 1;
//      g[a].Add(b);
//      g[b].Add(a);
//    }
//  }

//  private static (SortedSet<int>[] g, List<(int a, int b)> saveab) CreateList(int N)
//  {
//    List<(int a, int b)> saveab = new List<(int, int)>();
//    SortedSet<int>[] g = new SortedSet<int>[N];
//    for (int i = 0; i < N; i++)
//    {
//      g[i] = new SortedSet<int>();
//    }
//    for (int i = 0; i < N - 1; i++)
//    {
//      int[] ab = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//      int a = ab[0] - 1, b = ab[1] - 1;
//      saveab.Add((a, b));
//      g[a].Add(b);
//      g[b].Add(a);
//    }
//    return (g, saveab);
//  }

//  private static int[] CalDepth(SortedSet<int>[] g, int first, int N)
//  {
//    int[] depth = Enumerable.Repeat(-1, N).ToArray();
//    Queue<int> queue = new Queue<int>();
//    queue.Enqueue(first);
//    depth[first] = 0;
//    while (queue.Count != 0)
//    {
//      int current = queue.Dequeue();
//      foreach (var neighbor in g[current])
//      {
//        if (depth[neighbor] == -1)
//        {
//          depth[neighbor] = depth[current] + 1;
//          queue.Enqueue(neighbor);
//        }
//      }
//    }
//    return depth;
//  }
//}
