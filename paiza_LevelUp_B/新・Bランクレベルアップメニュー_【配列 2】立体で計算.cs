//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【配列 2】立体で計算 **********/
//    //【配列 1】平面で計算
//    //int N = int.Parse(Console.ReadLine());
//    //int[,] A = new int[N, N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    A[i, j] = temp[j];
//    //  }
//    //}
//    //int max = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int side = 0;
//    //  int vertical = 0;
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    side += A[i, j];
//    //    vertical += A[j, i];
//    //  }
//    //  max = Math.Max(max, side);
//    //  max = Math.Max(max, vertical);
//    //}
//    //int topLeft = 0;
//    //int topRight = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  topLeft += A[i, i];
//    //  topRight += A[i, N - 1 - i];
//    //}
//    //max = Math.Max(max, topLeft);
//    //max = Math.Max(max, topRight);
//    //Console.WriteLine(max);

//    //【配列 2】立体で計算
//    //int N = int.Parse(Console.ReadLine());
//    //int[,,] A = new int[N, N, N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //    for (int k = 0; k < N; k++)
//    //    {
//    //      A[i, j, k] = temp[k];
//    //    }
//    //  }
//    //}
//    //int max = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    int x1 = 0, x2 = 0;
//    //    int y1 = 0, y2 = 0;
//    //    int z1 = 0, z2 = 0;
//    //    for (int k = 0; k < N; k++)
//    //    {
//    //      x1 += A[i, j, k];
//    //      x2 += A[i, k, j];
//    //      y1 += A[j, i, k];
//    //      y2 += A[k, i, j];
//    //      z1 += A[j, k, i];
//    //      z2 += A[k, j, i];
//    //    }
//    //    max = Math.Max(max, x1);
//    //    max = Math.Max(max, x2);
//    //    max = Math.Max(max, y1);
//    //    max = Math.Max(max, y2);
//    //    max = Math.Max(max, z1);
//    //    max = Math.Max(max, z2);
//    //  }
//    //}
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int x1 = 0, x2 = 0;
//    //  int y1 = 0, y2 = 0;
//    //  int z1 = 0, z2 = 0;
//    //  for (int j = 0; j < N; j++)
//    //  {
//    //    x1 += A[i, j, j];
//    //    x2 += A[i, N - 1 - j, j];
//    //    y1 += A[j, i, j];
//    //    y2 += A[N - 1 - j, i, j];
//    //    z1 += A[j, j, i];
//    //    z2 += A[N - 1 - j, j, i];
//    //  }
//    //  max = Math.Max(max, x1);
//    //  max = Math.Max(max, x2);
//    //  max = Math.Max(max, y1);
//    //  max = Math.Max(max, y2);
//    //  max = Math.Max(max, z1);
//    //  max = Math.Max(max, z2);
//    //}

//    //int[] directionSum = new int[4];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  directionSum[0] += A[i, i, i];
//    //  directionSum[1] += A[i, i, N - 1 - i];
//    //  directionSum[2] += A[i, N - 1 - i, i];
//    //  directionSum[3] += A[i, N - 1 - i, N - 1 - i];
//    //}
//    //max = Math.Max(max, directionSum.Max());
//    //Console.WriteLine(max);
//  }
//}