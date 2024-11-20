//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 平方分割 **********/
//    //STEP: 1 累積和
//    //STEP: 2 区間和
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] A = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  A[i] = int.Parse(Console.ReadLine());
//    //}
//    //int[] S = new int[N + 1];
//    //for (int i = 1; i < N + 1; i++)
//    //{
//    //  S[i] = S[i - 1] + A[i - 1];
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int q = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(S[q]);
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int[] q = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int left = q[0] - 1, right = q[1];
//    //  Console.WriteLine(S[right] - S[left]);
//    //}

//    //STEP: 3 二次元累積和
//    //STEP: 4 二次元区間和
//    //int[] HWN = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = HWN[0], W = HWN[1], N = HWN[2];
//    //int[,] A = new int[H, W];
//    //int[,] S = new int[H + 1, W + 1];
//    //for (int i = 0; i < H; i++)
//    //{
//    //  int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < W; j++)
//    //  {
//    //    A[i, j] = temp[j];
//    //  }
//    //}
//    //for (int i = 1; i < H + 1; i++)
//    //{
//    //  for (int j = 1; j < W + 1; j++)
//    //  {
//    //    S[i, j] = S[i - 1, j] + S[i, j - 1] + A[i - 1, j - 1] - S[i - 1, j - 1];
//    //  }
//    //}
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] yx = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int y = yx[0], x = yx[1];
//    //  Console.WriteLine(S[y, x]);
//    //}
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int ly = line[0] - 1, lx = line[1] - 1, ry = line[2], rx = line[3];
//    //  Console.WriteLine(S[ry, rx] - S[ry, lx] - S[ly, rx] + S[ly, lx]);
//    //}

//    //STEP: 5 平方分割のバケット
//    //FINAL問題 平方分割
//    //int N = 10000;
//    //int K = int.Parse(Console.ReadLine());
//    //int x = (int)Math.Sqrt(N);
//    //int[][] A = new int[x][];
//    //for (int i = 0; i < x; i++)
//    //{
//    //  A[i] = new int[x];
//    //  for (int j = 0; j < x; j++)
//    //  {
//    //    A[i][j] = int.Parse(Console.ReadLine());
//    //  }
//    //}
//    //int[] maxs = Enumerable.Range(0, x).Select(i => A[i].Max()).ToArray();
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int[] lr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int left = lr[0] - 1, right = lr[1] - 1;
//    //  int max = int.MinValue;
//    //  int index = left;
//    //  while (index <= right)
//    //  {
//    //    if (index % x == 0 && index + x - 1 <= right)
//    //    {
//    //      max = Math.Max(max, maxs[index / x]);
//    //      index += x;
//    //    }
//    //    else
//    //    {
//    //      max = Math.Max(max, A[index / x][index % x]);
//    //      index++;
//    //    }
//    //  }
//    //  Console.WriteLine(max);
//    //}
//  }
//}
