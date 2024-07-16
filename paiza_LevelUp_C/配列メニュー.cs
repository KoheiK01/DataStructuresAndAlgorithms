using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
  static void Main()
  {
    //自分の得意な言語で
    //Let's チャレンジ！！
    /********** 【次元配列の入出力】i番目の出力 Boss **********/
    //1～9問目
    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int N = int.Parse(Console.ReadLine());
    //int K = int.Parse(Console.ReadLine());
    //int K = NK[1];
    //int[] A = { 5, 1, 3, 4, 5, 12, 6, 8, 1, 3, };
    //int[] A = { 8, 1, 3, 3, 8, 1, 1, 3, 8, 8, };
    //int[] A = { 1, 3, 5, 4, 6, 2, 1, 7, 1, 5, };
    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //Console.WriteLine(A.Count());
    //Console.WriteLine(string.Join("\n", A));
    //Console.WriteLine(A[3]);
    //Console.WriteLine(A[K - 1]);
    /********** 【二次元配列の入出力】i番目の出力 Boss **********/
    //1～7問目
    //int N = 2;
    //int[][] A = new int[N][];
    //A[0] = new int[] { 1, 2, 3, 4, 5, 6 };
    //A[1] = new int[] { 8, 1, 3, 3, 1, 8 };
    //A[0] = new int[] { 6, 5, 4, 3, 2, 1 };
    //A[1] = new int[] { 3, 1, 8, 8, 1, 3 };
    //A[0] = new int[] { 1, 2, 3 };
    //A[1] = new int[] { 4, 5, 6 };
    //A[2] = new int[] { 8, 1, 3 };
    //A[0] = new int[] { 1, 2, 3, 4 };
    //A[1] = new int[] { 6, 5, 4, 3 };
    //A[2] = new int[] { 3, 1, 8, 1 };
    //A[0] = new int[] { 1 };
    //A[1] = new int[] { 2, 3 };
    //A[2] = new int[] { 4, 5, 6 };
    //A[0] = new int[] { 1, 2, 3 };
    //A[1] = new int[] { 8, 1, 3 };
    //A[2] = new int[] { 10, 100, 1 };
    //A[0] = new int[] { 1, 3, 5, 7 };
    //A[1] = new int[] { 8, 1, 3, 8 };
    //Console.WriteLine(A[0].Count() + A[1].Count());
    //Console.WriteLine(A[0].Count());
    //Console.WriteLine(A[1][2]);
    //for (int i = 0; i < N; i++)
    //{
    //  Console.WriteLine(string.Join(" ", A[i]));
    //Console.WriteLine(A[i].Count());
    //}
    //8～10問目
    //int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int N = 5;
    //int N = int.Parse(Console.ReadLine());
    //int N = NM[0];
    //int M = int.Parse(Console.ReadLine());
    //int[][] A = new int[N][];
    //for (int i = 0; i < N; i++)
    //{
    //  A[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //}
    //for (int i = 0; i < N; i++)
    //{
    //  Console.WriteLine(string.Join(" ", A[i]));
    //}
    //11～13問目
    //int[] NMKD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int N = 3;
    //int N = NMKD[0];
    //int[][] A = new int[N][];
    //A[0] = new int[] { 1, 2, 3, 4 };
    //A[1] = new int[] { 10, 100, 0, 5 };
    //A[2] = new int[] { 8, 1, 3, 8 };
    //A[3] = new int[] { 15, 34, 94, 25 };
    //for (int i = 0; i < N; i++)
    //{
    //  A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //}
    //Console.WriteLine(A[NMKD[2] - 1][NMKD[3] - 1]);
    /********** 【配列の検索】何個ある? Boss **********/
    //1～3問目
    //int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int serch = 6;
    //int serch = int.Parse(Console.ReadLine());
    //int serch = NM[1];
    //int[] A = { 10, 13, 21, 1, 6, 51, 10, 8, 15, 6, };
    //int[] A = { 5, 12, 6, 84, 14, 25, 44, 3, 7, 20, };
    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //Console.WriteLine(A.Contains(serch) ? "Yes" : "No");
    //4～6問目
    //int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int serch = 8;
    //int serch = int.Parse(Console.ReadLine());
    //int serch = NM[0];
    //int[] A = { 1, 10, 2, 9, 3, 8, 4, 7, 5, 6, };
    //int[] A = { 1, 5, 9, 7, 3, 2, 4, 8, 6, 10, };
    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //Console.WriteLine(Array.IndexOf(A, serch) + 1);
    //7～9問目
    //int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int serch = 1;
    //int serch = int.Parse(Console.ReadLine());
    //int serch = NM[0];
    //int[] A = { 1, 2, 2, 1, 2, 1, 2, 1, 1, 1, };
    //int[] A = { 1, 2, 5, 1, 4, 3, 2, 5, 1, 4, };
    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //Console.WriteLine(A.Count(a => a == serch));
  }
}