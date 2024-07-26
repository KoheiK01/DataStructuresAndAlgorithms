//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Net;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【配列を参照する操作】全ての要素に対する操作 **********/
//    //1～8問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = int.Parse(Console.ReadLine());
//    //}
//    //int ans = As.Count(a => a == K);
//    //int ans = As.Sum();
//    //int ans = As.Max();
//    //int ans = As.Min();
//    //int ans = Array.IndexOf(As, K);
//    //ans = ans == -1 ? -1 : ans + 1;
//    //As = As.Distinct().ToArray();
//    //int ans = As.Count();
//    //As = As.Select(a => a + K).ToArray();
//    //string ans = As.Contains(K) ? "Yes" : "No";
//    //Console.WriteLine(ans);
//    //Console.WriteLine(string.Join("\n", As));
//    /********** 【配列への副作用を伴う操作】条件を満たす要素のみの配列作成 **********/
//    //1～3問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] nB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int X = nB[0], Y = nB[1];
//    //int[] Bs = As.Reverse().ToArray();
//    //int tmp = As[Y - 1];
//    //As[Y - 1] = As[X - 1];
//    //As[X - 1] = tmp;
//    //Console.WriteLine(string.Join("\n", As));
//    //Console.WriteLine(string.Join(" ", Bs));
//    //Console.WriteLine(string.Join("\n", Bs));
//    //4～6問目
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> As = new List<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As.Add(int.Parse(Console.ReadLine()));
//    //}
//    //int n = int.Parse(Console.ReadLine());
//    //int B = int.Parse(Console.ReadLine());
//    //int[] nB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int n = nB[0], B = nB[1];
//    //As.Insert(n, B);
//    //As.RemoveAt(n - 1);
//    //Console.WriteLine(string.Join("\n", As));
//    //8問目
//    //for (int i = 1; i <= 9; i++)
//    //{
//    //  int[] rows = Enumerable.Range(1, 9).Select(x => x * i).ToArray();
//    //  Console.WriteLine(string.Join(" ", rows));
//    //}
//    //9問目
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> As = new List<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As.Add(int.Parse(Console.ReadLine()));
//    //  for (int j = 0; j < i; j++)
//    //  {
//    //    Console.WriteLine(As[i] * As[j]);
//    //  }
//    //}
//    //10～11問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] Nn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = Nn[0], n = Nn[1];
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] Bs = new int[n];
//    //Array.Copy(As, Bs, Math.Min(N, n));
//    //int[] Bs = As.Distinct().ToArray();
//    //int[] Bs = As.Where(x => x >= K).ToArray();
//    //Console.WriteLine(string.Join("\n", Bs));
//    /********** 【配列に対しての複雑な処理】集団行動 **********/
//    //1問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] M = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < scores.Length; j++)
//    //  {
//    //    As[i] += scores[j] * M[j];
//    //  }
//    //}
//    //Console.WriteLine(As.Max());
//    //2問目
//    //int[] NKM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NKM[0], K = NKM[1], M = NKM[2];
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = int.Parse(Console.ReadLine());
//    //}
//    //int count = As.Count(x => x >= K);
//    //int result = Math.Max(count - M, 0);
//    //Console.WriteLine(result);  
//    //3問目
//    //int N = int.Parse(Console.ReadLine());
//    //Queue<int> As = new Queue<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split(' ');
//    //  if (words[0] == "in")
//    //  {
//    //    As.Enqueue(int.Parse(words[1]));
//    //  }
//    //  else if (As.Count != 0)
//    //  {
//    //    As.Dequeue();
//    //  }
//    //}
//    //Console.WriteLine(string.Join("\n", As));
//    //4問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = int.Parse(Console.ReadLine());
//    //}
//    //Array.Sort(As);
//    //int h1 = 0, h2 = 0, min = int.MaxValue;
//    //for (int i = 1; i < N; i++)
//    //{
//    //  int diff = As[i] - As[i - 1];
//    //  if (diff < min)
//    //  {
//    //    h1 = As[i];
//    //    h2 = As[i - 1];
//    //    min = diff;
//    //  }
//    //}
//    //Console.WriteLine(h2 + "\n" + h1);
//    //5問目
//    //int[] NKF = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NKF[0], K = NKF[1], F = NKF[2];
//    //List<int> As = new List<int>();
//    //for (int i = 0; i < K; i++)
//    //{
//    //  As.Add(int.Parse(Console.ReadLine()));
//    //}
//    //As.RemoveRange(0, F);
//    //As = As.Distinct().ToList();
//    //Console.WriteLine(string.Join("\n", As));
//    //6問目
//    //int[] pins = new int[10];
//    //int index = 9;
//    //for (int i = 0; i < 4; i++)
//    //{
//    //  int[] rows = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //  for (int j = 0; j < rows.Length; j++)
//    //  {
//    //    pins[index] = rows[j];
//    //    index--;
//    //  }
//    //}
//    //for (int i = 0; i < 10; i++)
//    //{
//    //  if (pins[i] == 1)
//    //  {
//    //    Console.WriteLine(i + 1);
//    //    break;
//    //  }
//    //}
//    //Console.WriteLine(pins.Sum());
//    //7問目
//    //int[] NQ = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NQ[0], Q = NQ[1];
//    //List<int> As = Enumerable.Range(1, N).ToList();
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split(' ');
//    //  if (words[0] == "swap")
//    //  {
//    //    int A = int.Parse(words[1]), B = int.Parse(words[2]);
//    //    int tmp = As[A - 1];
//    //    As[A - 1] = As[B - 1];
//    //    As[B - 1] = tmp;
//    //  }
//    //  else if (words[0] == "reverse")
//    //  {
//    //    As.Reverse();
//    //  }
//    //  else
//    //  {
//    //    int C = int.Parse(words[1]);
//    //    if (As.Count > C)
//    //    {
//    //      As.RemoveRange(C, As.Count - C);
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(string.Join("\n", As));
//  }
//}