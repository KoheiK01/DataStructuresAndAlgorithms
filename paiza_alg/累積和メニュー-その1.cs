//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 【区間の和】 区間の和 4 **************/
//    //int[] XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] NXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] A = { 1, 5, 9, 7, 5, 3, 2, 5, 8, 4 };
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] S = new int[A.Length + 1];
//    //for (int i = 0; i < A.Length; i++)
//    //{
//    //  S[i + 1] = S[i] + A[i];
//    //}
//    //Console.WriteLine(S[8] - S[2]);
//    //Console.WriteLine(S[XY[1] + 1] - S[XY[0]]);
//    //Console.WriteLine(S[NXY[2] + 1] - S[NXY[1]]);

//    /********** 【連続する N 個の和の最大値】 連続する N 個の和の最大値 4 **************/
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] A = { 1, 5, 9, 7, 5, 3, 2, 5, 8, 4 };
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] S = new int[A.Length + 1];
//    //for (int i = 0; i < A.Length; i++)
//    //{
//    //  S[i + 1] = S[i] + A[i];
//    //}
//    //int Max = 0;
//    //for (int i = 3; i < S.Length; i++)
//    //{
//    //  Max = Math.Max(Max, S[i] - S[i - 3]);
//    //}
//    //for (int i = NK[1]; i < S.Length; i++)
//    //{
//    //  Max = Math.Max(Max, S[i] - S[i - NK[1]]);
//    //}
//    //Console.WriteLine(Max);

//    /********** 【区間内の個数】区間内の個数 4 **************/
//    /********** 【区間内の個数 (文字列) 】 区間内の個数 (文字列) 4 **************/
//    //int[] NXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] XY = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] A = { 1, 5, 9, 7, 5, 3, 2, 5, 8, 4 };
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //string A = "bwwbwbbwbwbb";
//    //string A = Console.ReadLine();
//    //int[] B = new int[A.Length];
//    //for (int i = 0; i < A.Length; i++)
//    //{
//    //  if (A[i] % 2 == 0) { B[i] = 1; }
//    //  if (A[i] == 'b') { B[i] = 1; }
//    //}
//    //int[] S = new int[B.Length + 1];
//    //for (int i = 0; i < B.Length; i++)
//    //{
//    //  S[i + 1] = S[i] + B[i];
//    //}
//    //Console.WriteLine(S[8] - S[2]);
//    //Console.WriteLine(S[XY[1] + 1] - S[XY[0]]);
//    //Console.WriteLine(S[XY[1]] - S[XY[0] - 1]);
//    //Console.WriteLine(S[NXY[2] + 1] - S[NXY[1]]);
//    //Console.WriteLine(S[NXY[2]] - S[NXY[1] - 1]);

//    /********** 【二次元累積和】 二次元累積和 7 **************/
//    //int N = 5, M = 5, Q = 1;
//    //int a = 1, b = 1, c = 3, d = 3;
//    //N = int.Parse(Console.ReadLine());
//    //M = N;
//    //int[] NMQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //N = NMQ[0]; M = NMQ[1]; Q = NMQ[2];
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //a = input[0]; c = input[1]; b = 3;
//    //a = input[0]; b = input[1]; c = input[2]; d = input[3];
//    //int[,] A =
//    //{
//    //     {1, 2, 3, 4, 5 },
//    //     {2, 3, 4, 5, 6 },
//    //     {3, 4, 5, 6, 7 },
//    //     {4, 5, 6, 7, 8 },
//    //     {5, 6, 7, 8, 9 }
//    // };
//    //int[,] A = new int[N, M];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < M; j++)
//    //  {
//    //    A[i, j] = temp[j];
//    //  }
//    //}
//    //int[,] S = new int[N + 1, M + 1];
//    //for (int y = 1; y <= N; y++)
//    //{
//    //  for (int x = 1; x <= M; x++)
//    //  {
//    //    S[y, x] = S[y, x - 1] + S[y - 1, x] + A[y - 1, x - 1] - S[y - 1, x - 1];
//    //  }
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  a = input[0]; b = input[1]; c = input[2]; d = input[3];
//    //  Console.WriteLine(S[c + 1, d + 1] - S[a, d + 1] - S[c + 1, b] + S[a, b]);
//    //}
//  }
//}
