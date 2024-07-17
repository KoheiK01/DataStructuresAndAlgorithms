//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 動的配列 **********/
//    //1問目
//    //int[] fLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(A[fLine[1] - 1]);
//    //2問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int Q = int.Parse(Console.ReadLine());
//    //int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  Console.WriteLine(A[B[i] - 1]);
//    //}
//    //3問目
//    //int[] ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(ABC.Max() - ABC.Min());
//    //4問目
//    //int[] fLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //List<int> A = Console.ReadLine().Split().Select(int.Parse).ToList();
//    //for (int i = 0; i < fLine[1]; i++)
//    //{
//    //  int[] qi= Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  if (qi[0] == 0)
//    //  {
//    //    A.Add(qi[1]);
//    //  }
//    //  else if (qi[0] == 1)
//    //  {
//    //    A.RemoveAt(A.Count - 1);
//    //  }
//    //  else
//    //  {
//    //    Console.WriteLine(string.Join(" ",A));
//    //  }
//    //}
//    /********** 文字列の配列 **********/
//    //1～2問目
//    //Console.WriteLine(Console.ReadLine());
//    //3問目
//    //int[] fLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //char[,] _maps = new char[fLine[0], fLine[1]];
//    //for (int i = 0; i < fLine[0]; i++)
//    //{
//    //  string s = Console.ReadLine();
//    //  for (int j = 0; j < s.Length; j++)
//    //  {
//    //    _maps[i, j] = s[j];
//    //  }
//    //}
//    //string ans = "No";
//    //if (_maps[fLine[2] - 1, fLine[3] - 1] == '#')
//    //{
//    //  ans = "Yes";
//    //}
//    //Console.WriteLine(ans);
//    /********** 商品の検索 **********/
//    //1問目
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
//    //int[] ans = Enumerable.Range(0, 10).Select(i => list.Count(x => x == i)).ToArray();
//    //Console.WriteLine(string.Join(" ", ans));
//    //2問目
//    //int N = int.Parse(Console.ReadLine());
//    //string S = Console.ReadLine();
//    //アルファベットは簡単に出せる!!!
//    //int[] ans = Enumerable.Range('a', 26).Select(i => S.Count(x => x == i)).ToArray();
//    //Console.WriteLine(string.Join(" ", ans));
//    //3問目
//    //int N = int.Parse(Console.ReadLine());
//    //Dictionary<string, int> dict = new Dictionary<string, int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string key = Console.ReadLine();
//    //  if (dict.ContainsKey(key))
//    //  {
//    //    dict[key]++;
//    //  }
//    //  else
//    //  {
//    //    dict.Add(key, 1);
//    //  }
//    //}
//    //dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
//    //Console.WriteLine(string.Join("\n", dict.Select(x => x.Key + " " + x.Value)));
//    //4問目
//    //int[] fline = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
//    //int N = fline[0];
//    //int M = fline[1];
//    //Dictionary<string, int> goods = new Dictionary<string, int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] good = Console.ReadLine().Split();
//    //  goods.Add(good[0], int.Parse(good[1]));
//    //}
//    //for (int i = 0; i < M; i++)
//    //{
//    //  string name = Console.ReadLine();
//    //  if (goods.ContainsKey(name))
//    //  {
//    //    Console.WriteLine(goods[name]);
//    //  }
//    //  else
//    //  {
//    //    Console.WriteLine(-1);
//    //  }
//    //}
//    //5問目
//    //int[] fline = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
//    //int N = fline[0];
//    //int Q = fline[1];
//    //List<string> _strings = new List<string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  _strings.Add(Console.ReadLine());
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  string t = Console.ReadLine();
//    //  int ans = _strings.IndexOf(t);
//    //  Console.WriteLine(ans == -1 ? ans : ans + 1);
//    //}
//    /********** 集合の結合 **********/
//    //1問目
//    //int[] fline = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
//    //int[] A = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
//    //Console.WriteLine(A.Contains(fline[1]) ? "Yes" : "No");
//    //2問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] ans = Console.ReadLine().Split().Select(x => int.Parse(x)).Distinct().ToArray();
//    //Console.WriteLine(string.Join(" ", ans));
//    //3～4問目
//    //int N = int.Parse(Console.ReadLine());
//    //string[] A = Console.ReadLine().Split(' ');
//    //List<string> list = new List<string>() { A[0] };
//    //for (int i = 1; i < N; i++)
//    //{
//    //  if (list.Contains(A[i]))
//    //  {
//    //    Console.WriteLine("Yes");
//    //  }
//    //  else
//    //  {
//    //    Console.WriteLine("No");
//    //    list.Add(A[i]);
//    //  }
//    //}
//    //5問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[] B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //var ans = A.Concat(B).Distinct().OrderBy(x => x).ToArray();
//    //Console.WriteLine(string.Join(" ", ans));
//  }
//}