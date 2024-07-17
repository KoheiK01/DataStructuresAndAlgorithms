//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography;
//using System.Security.Cryptography.X509Certificates;
//using System.Text.RegularExpressions;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【次元配列の入出力】i番目の出力 Boss **********/
//    //1～9問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = int.Parse(Console.ReadLine());
//    //int K = int.Parse(Console.ReadLine());
//    //int K = NK[1];
//    //int[] A = { 5, 1, 3, 4, 5, 12, 6, 8, 1, 3, };
//    //int[] A = { 8, 1, 3, 3, 8, 1, 1, 3, 8, 8, };
//    //int[] A = { 1, 3, 5, 4, 6, 2, 1, 7, 1, 5, };
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Console.WriteLine(A.Count());
//    //Console.WriteLine(string.Join("\n", A));
//    //Console.WriteLine(A[3]);
//    //Console.WriteLine(A[K - 1]);
//    /********** 【二次元配列の入出力】i番目の出力 Boss **********/
//    //1～7問目
//    //int N = 2;
//    //int[][] A = new int[N][];
//    //A[0] = new int[] { 1, 2, 3, 4, 5, 6 };
//    //A[1] = new int[] { 8, 1, 3, 3, 1, 8 };
//    //A[0] = new int[] { 6, 5, 4, 3, 2, 1 };
//    //A[1] = new int[] { 3, 1, 8, 8, 1, 3 };
//    //A[0] = new int[] { 1, 2, 3 };
//    //A[1] = new int[] { 4, 5, 6 };
//    //A[2] = new int[] { 8, 1, 3 };
//    //A[0] = new int[] { 1, 2, 3, 4 };
//    //A[1] = new int[] { 6, 5, 4, 3 };
//    //A[2] = new int[] { 3, 1, 8, 1 };
//    //A[0] = new int[] { 1 };
//    //A[1] = new int[] { 2, 3 };
//    //A[2] = new int[] { 4, 5, 6 };
//    //A[0] = new int[] { 1, 2, 3 };
//    //A[1] = new int[] { 8, 1, 3 };
//    //A[2] = new int[] { 10, 100, 1 };
//    //A[0] = new int[] { 1, 3, 5, 7 };
//    //A[1] = new int[] { 8, 1, 3, 8 };
//    //Console.WriteLine(A[0].Count() + A[1].Count());
//    //Console.WriteLine(A[0].Count());
//    //Console.WriteLine(A[1][2]);
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(string.Join(" ", A[i]));
//    //Console.WriteLine(A[i].Count());
//    //}
//    //8～10問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = 5;
//    //int N = int.Parse(Console.ReadLine());
//    //int N = NK[0];
//    //int M = int.Parse(Console.ReadLine());
//    //int[][] A = new int[N][];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  A[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //}
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(string.Join(" ", A[i]));
//    //}
//    //11～13問目
//    //int[] NMKD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = 3;
//    //int N = NMKD[0];
//    //int[][] A = new int[N][];
//    //A[0] = new int[] { 1, 2, 3, 4 };
//    //A[1] = new int[] { 10, 100, 0, 5 };
//    //A[2] = new int[] { 8, 1, 3, 8 };
//    //A[3] = new int[] { 15, 34, 94, 25 };
//    //for (int i = 0; i < N; i++)
//    //{
//    //  A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //}
//    //Console.WriteLine(A[NMKD[2] - 1][NMKD[3] - 1]);
//    /********** 【配列の検索】何個ある? Boss **********/
//    //1～3問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int serch = 6;
//    //int serch = int.Parse(Console.ReadLine());
//    //int serch = NK[1];
//    //int[] A = { 10, 13, 21, 1, 6, 51, 10, 8, 15, 6, };
//    //int[] A = { 5, 12, 6, 84, 14, 25, 44, 3, 7, 20, };
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Console.WriteLine(A.Contains(serch) ? "Yes" : "No");
//    //4～6問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int serch = 8;
//    //int serch = int.Parse(Console.ReadLine());
//    //int serch = NK[0];
//    //int[] A = { 1, 10, 2, 9, 3, 8, 4, 7, 5, 6, };
//    //int[] A = { 1, 5, 9, 7, 3, 2, 4, 8, 6, 10, };
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Console.WriteLine(Array.IndexOf(A, serch) + 1);
//    //7～9問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int serch = 1;
//    //int serch = int.Parse(Console.ReadLine());
//    //int serch = NK[0];
//    //int[] A = { 1, 2, 2, 1, 2, 1, 2, 1, 1, 1, };
//    //int[] A = { 1, 2, 5, 1, 4, 3, 2, 5, 1, 4, };
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Console.WriteLine(A.Count(a => a == serch));
//    /********** 【文字列の配列】辞書順に出力 Boss **********/
//    //1問目
//    //int[] ABN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //A = A.Select(x => x == ABN[0] ? ABN[1] : x).ToArray();
//    //Console.WriteLine(string.Join("\n", A));
//    //2問目
//    //int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int A = AB[1], B = AB[0];
//    //Console.WriteLine(A + " " + B);
//    //3～4問目
//    //int[] ABN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int A = ABN[0], B = ABN[1], N = ABN[2];
//    //int[] As = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int temp = As[B - 1];
//    //As[B - 1] = As[A - 1];
//    //As[A - 1] = temp;
//    //As = As.Skip(A - 1).Take(B - A + 1).ToArray();
//    //Console.WriteLine(string.Join("\n", As));
//    //5問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], M = NK[1];
//    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] Bs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //As = As.Concat(Bs).ToArray();
//    //Console.WriteLine(string.Join("\n", As));
//    //6～11問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[] NML = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], M = NK[1];
//    //int N = NML[0], M = NML[1], K = NML[2];
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> As = Console.ReadLine().Split().Select(int.Parse).ToList();
//    //As.RemoveAt(M - 1);
//    //忘れがちだけど便利なメソッドがListにはある!!!
//    //As.Insert(M - 1, K);
//    //Array.Sort(As);
//    //As = As.Reverse().ToArray();
//    //int result = As.Count(x => x == M);
//    //Console.WriteLine(result);
//    //Console.WriteLine(string.Join("\n", As));
//    //12～15・18～21問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[] NML = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], M = NK[1];
//    //int N = NML[0], M = NML[1], L = NML[2];
//    //int index = N - 1;
//    //int index = 2;
//    //int index = int.Parse(Console.ReadLine()) - 1;
//    //List<string> As = new List<string>() { "good", "morning", "paiza", "813", "pa13" };
//    //List<string> As = new List<string>() { "eight", "one", "three", "paiza", "pa13", "813" };
//    //List<string> As = Console.ReadLine().Split().ToList();
//    //Console.WriteLine(As.Count);
//    //Console.WriteLine(As[index]);
//    //Console.WriteLine(As[index][L - 1]);
//    //Console.WriteLine(string.Join("\n", As));
//    //16～17問目
//    //int N = int.Parse(Console.ReadLine());
//    //List<string> As = Console.ReadLine().Split().ToList();
//    //Console.WriteLine(string.Join("\n", As));
//    //22問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int N = int.Parse(Console.ReadLine());
//    //List<string> As = ("zaipa izapa paiza").Split().ToList();
//    //List<string> As = Console.ReadLine().Split().ToList();
//    //As.Sort();
//    //Console.WriteLine(As[K - 1]);
//    //Console.WriteLine(string.Join("\n", As));
//    /********** フィボナッチ数 **********/
//    //1問目
//    //List<int> As = ("1 3 5 1 2 3 6 6 5 1 4").Split().Distinct().Select(int.Parse).ToList();
//    //As.Sort();
//    //Console.WriteLine(string.Join("\n", As));
//    //2～5問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> As = Console.ReadLine().Split().Select(int.Parse).ToList();
//    //double K = As.Average();
//    //As = As.Where(x => x >= K).ToList();
//    //Console.WriteLine(As.Max() + " " + As.Min());
//    //Console.WriteLine(string.Join("\n", As));
//    //6～7問目
//    //int[] NAB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NAB[0], A = NAB[1], B = NAB[2];
//    //List<Spot> spots = new List<Spot>();
//    //int N = int.Parse(Console.ReadLine());
//    //int baseX = 2, baseY = 3;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] xy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //  int x = xy[0], y = xy[1];
//    //  spots.Add(new Spot(x, y));
//    //int distance = Math.Abs(x - baseX) + Math.Abs(y - baseY);
//    //Console.WriteLine(distance);
//    //}
//    //int distance =
//    //  Math.Abs(spots[A - 1].X - spots[B - 1].X) + Math.Abs(spots[A - 1].Y - spots[B - 1].Y);
//    //Console.WriteLine(distance);
//    //8問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] As = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  if (i == 0) As[i] = 0;
//    //  else if (i == 1) As[i] = 1;
//    //  else As[i] = As[i - 2] + As[i - 1];
//    //  Console.WriteLine(As[i]);
//    //}
//  }
//}

////class Spot
////{
////  public int X;
////  public int Y;
////  public Spot(int x, int y)
////  {
////    X = x; Y = y;
////  }
////}