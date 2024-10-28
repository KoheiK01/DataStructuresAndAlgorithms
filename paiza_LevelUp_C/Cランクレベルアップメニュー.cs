//using System;
//using System.Collections.Generic;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 標準入出力 **********/
//    //1問目
//    //string A = Console.ReadLine();
//    //Console.WriteLine(A);
//    //2問目
//    //int n = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < n; i++)
//    //{
//    //  Console.WriteLine("paiza");
//    //}
//    //3～6問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //string[] A = new string[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //A[i] = int.Parse(Console.ReadLine());
//    //A[i] = "paiza";
//    //}
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(string.Join("\n", A));
//    //Console.WriteLine(A.Max());
//    //Console.WriteLine(string.Join(" ", A));
//    //7問目
//    //int n = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split();
//    //  string name = words[0];
//    //  int age = int.Parse(words[1]) + 1;
//    //  Console.WriteLine(name + " " + age);
//    //}
//    /********** 文字列 **********/
//    //1問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string s = Console.ReadLine();
//    //  A[i] = s.Length;
//    //}
//    //Console.WriteLine(string.Join("\n", A));
//    //2問目
//    //string a = Console.ReadLine();
//    //string S = Console.ReadLine();
//    //Console.WriteLine(S.Contains(a) ? "YES" : "NO");
//    //3問目
//    //string s = Console.ReadLine();
//    //int a = int.Parse(s[0].ToString()) + int.Parse(s[3].ToString());
//    //int b = int.Parse(s[1].ToString()) + int.Parse(s[2].ToString());
//    //Console.WriteLine(a.ToString() + b.ToString());
//    //4問目
//    //int a = int.Parse(Console.ReadLine());
//    //Console.WriteLine("{0:000}", a);
//    //5～6問目
//    //int[] hm = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
//    //int h = hm[0], m = hm[1];
//    //m += 30;
//    //h += m / 60;
//    //m %= 60;
//    //Console.WriteLine($"{h:00}:{m:00}");
//    //Console.WriteLine(string.Join("\n",hm));
//    //7問目
//    //int n = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split(' ');
//    //  string[] time = line[0].Split(':');
//    //  int hour = int.Parse(time[0]), minute = int.Parse(time[1]);
//    //  int workHour = int.Parse(line[1]), workMinute = int.Parse(line[2]);
//    //  hour += workHour; minute += workMinute;
//    //  hour += minute / 60; minute %= 60;
//    //  hour %= 24;
//    //  Console.WriteLine($"{hour:00}:{minute:00}");
//    //}
//    /********** forループ **********/
//    //1問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int ans = A.Where(a => a % 3 == 0).Count();
//    //Console.WriteLine(ans);
//    //2問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //Console.WriteLine(A.Any(a => a == 7) ? "YES" : "NO");
//    //3問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = new int[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int k = int.Parse(Console.ReadLine());
//    //int ans = Enumerable.Range(0, n)
//    //  .Where(i => A[i] == k).Min();
//    //Console.WriteLine(ans + 1);
//    //4問目
//    //int m = int.Parse(Console.ReadLine());
//    //string[] C = new string[m];
//    //for (int i = 0; i < m; i++)
//    //{
//    //  C[i] = Console.ReadLine();
//    //}
//    //int n = int.Parse(Console.ReadLine());
//    //string[] S = new string[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  S[i] = Console.ReadLine();
//    //}
//    //for (int i = 0; i < m; i++)
//    //{
//    //  for (int j = 0; j < n; j++)
//    //  {
//    //    if (S[j].Contains(C[i]))
//    //    {
//    //      Console.WriteLine("YES");
//    //    }
//    //    else
//    //    {
//    //      Console.WriteLine("NO");
//    //    }
//    //  }
//    //}
//    //5問目
//    //int[] NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = NMK[0], M = NMK[1], K = NMK[2];
//    //int[][] A = new int[n][];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  Console.WriteLine(A[i].Count(a => a == K));
//    //}
//    /********** ソート **********/
//    //1～2問目
//    //int n = int.Parse(Console.ReadLine());
//    //List<int> A = new List<int>();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  A.Add(int.Parse(Console.ReadLine()));
//    //}
//    //A = A.OrderBy(x => x).ToList();
//    //A = A.OrderByDescending(x => x).ToList();
//    //Console.WriteLine(string.Join("\n", A));
//    //3問目
//    //int n = int.Parse(Console.ReadLine());
//    //List<(int apple, int banana)> A = new List<(int, int)>();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //  A.Add((line[0], line[1]));
//    //}
//    //A = A
//    //  .OrderByDescending(x => x.apple)
//    //  .ThenByDescending(x => x.banana)
//    //  .ToList();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  Console.WriteLine($"{A[i].apple} {A[i].banana}");
//    //}
//    //4問目
//    //int n = int.Parse(Console.ReadLine());
//    //List<(int gold, int silver)> A = new List<(int, int)>();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //  A.Add((line[0], line[1]));
//    //}
//    //A = A
//    //  .OrderByDescending(x => x.silver)
//    //  .ThenByDescending(x => x.gold)
//    //  .ToList();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  Console.WriteLine($"{A[i].gold} {A[i].silver}");
//    //}
//    /********** 辞書 **********/
//    //1問目
//    //Dictionary<string, int> _keyValuePairs = new Dictionary<string, int>();
//    //int n = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split(' ');
//    //  _keyValuePairs[line[0]] = int.Parse(line[1]);
//    //}
//    //Console.WriteLine(_keyValuePairs[Console.ReadLine()]);
//    //2～3問目
//    //Dictionary<string, int> _keyValuePairs = new Dictionary<string, int>();
//    //int n = int.Parse(Console.ReadLine());
//    //string name;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  name = Console.ReadLine();
//    //  _keyValuePairs[name] = 0;
//    //}
//    //int m = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < m; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split();
//    //  name = line[0]; int monsterAttack = int.Parse(line[1]);
//    //  _keyValuePairs[name] += monsterAttack;
//    //}
//    //_keyValuePairs = _keyValuePairs
//    //  .OrderBy(x => x.Key)
//    //  .ToDictionary(x => x.Key, x => x.Value);
//    //Console.WriteLine(string.Join("\n", _keyValuePairs.Values.ToArray()));
//    //name = Console.ReadLine();
//    //Console.WriteLine(_keyValuePairs[name]);
//    //4問目
//    //Dictionary<int, int> AB = new Dictionary<int, int>();
//    //Dictionary<int, int> BC = new Dictionary<int, int>();
//    //int[] pqr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int p = pqr[0], q = pqr[1], r = pqr[2];
//    //for (int i = 0; i < p; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  AB[line[0]] = line[1];
//    //}
//    //for (int i = 0; i < q; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  BC[line[0]] = line[1];
//    //}
//    //AB = AB
//    //  .OrderBy(x => x.Key)
//    //  .ToDictionary(x => x.Key, x => x.Value);
//    //foreach (var item in AB)
//    //{
//    //  int to = BC[item.Value];
//    //  Console.WriteLine(item.Key + " " + to);
//    //}
//    /********** シミュレーション **********/
//    //1問目
//    //int num = 10000;
//    //while(true)
//    //{
//    //  if(num % 13 == 0)
//    //  {
//    //    Console.WriteLine(num);
//    //    break;
//    //  }
//    //  num++;
//    //}
//    //2問目
//    //int n = int.Parse(Console.ReadLine());
//    //int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int a = ab[0], b = ab[1];
//    //int paiza = 1;
//    //int kirishima = 1;
//    //int count = 0;
//    //while (kirishima <= n)
//    //{
//    //  kirishima += a * paiza;
//    //  paiza += kirishima % b;
//    //  count++;
//    //}
//    //Console.WriteLine(count);
//    //3問目
//    //int H = int.Parse(Console.ReadLine());
//    //List<int> paizaAttacks = new List<int> { 1, 1 };
//    //List<int> monsterAttacks = new List<int> { 1, 1 };
//    //H -= 2;
//    //int count = 2;
//    //while (H > 0)
//    //{
//    //  int paizaAttack = monsterAttacks[count - 1] + monsterAttacks[count - 2];
//    //  int monsterAttack = paizaAttacks[count - 1] * 2 + paizaAttacks[count - 2];
//    //  H -= monsterAttack;
//    //  paizaAttacks.Add(monsterAttacks[count - 1] + monsterAttacks[count - 2]);
//    //  monsterAttacks.Add(paizaAttacks[count - 1] * 2 + paizaAttacks[count - 2]);
//    //  count++;
//    //}
//    //Console.WriteLine(count);
//  }
//}
