//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 点の幅 **********/
//    //STEP: 1 'I' の数
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
//    //float third = (float)N / 3;
//    //for (int i = 0; i < K; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int al = line[0], ar = line[1];
//    //  int bl = line[2], br = line[3];
//    //  int aPage = ar - al + 1, bPage = br - bl + 1;
//    //  int aPoint = S[ar] - S[al - 1];
//    //  int bPoint = S[br] - S[bl - 1];
//    //  if (aPage >= third) { aPoint = -1; }
//    //  if (bPage >= third) { bPoint = -1; }
//    //  if (aPoint > bPoint) { Console.WriteLine("A"); }
//    //  else if (aPoint < bPoint) { Console.WriteLine("B"); }
//    //  else { Console.WriteLine("DRAW"); }
//    //}

//    //STEP: 2 ドーナツ
//    //int[] HWN = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = HWN[0], W = HWN[1], N = HWN[2];
//    //int[,] chocolates = new int[H, W];
//    //for (int h = 0; h < H; h++)
//    //{
//    //  int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int w = 0; w < W; w++)
//    //  {
//    //    chocolates[h, w] = temp[w];
//    //  }
//    //}
//    //int[,] Sum = new int[H + 1, W + 1];
//    //for (int h = 1; h < H + 1; h++)
//    //{
//    //  for (int w = 1; w < W + 1; w++)
//    //  {
//    //    Sum[h, w] = Sum[h - 1, w] + Sum[h, w - 1] + chocolates[h - 1, w - 1] - Sum[h - 1, w - 1];
//    //  }
//    //}
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int y = line[0], x = line[1], B = line[2], S = line[3];
//    //  int r = (B - 1) / 2;
//    //  int ry = y + r, rx = x + r;
//    //  int ly = y - r, lx = x - r;
//    //  int big = Sum[ry, rx] - Sum[ry, lx - 1] - Sum[ly - 1, rx] + Sum[ly - 1, lx - 1];
//    //  r = (S - 1) / 2;
//    //  ry = y + r; rx = x + r;
//    //  ly = y - r; lx = x - r;
//    //  int small = Sum[ry, rx] - Sum[ry, lx - 1] - Sum[ly - 1, rx] + Sum[ly - 1, lx - 1];
//    //  Console.WriteLine(big - small);
//    //}

//    //FINAL問題 点の幅
//  //  int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//  //  int N = NK[0], K = NK[1];
//  //  int x = (int)Math.Sqrt(N);

//  //  int[][] A = new int[x][];
//  //  for (int i = 0; i < x; i++)
//  //  {
//  //    A[i] = new int[x];
//  //    for (int j = 0; j < x; j++)
//  //    {
//  //      A[i][j] = int.Parse(Console.ReadLine());
//  //    }
//  //  }

//  //  int[] maxs = Enumerable.Range(0, x).Select(i => A[i].Max()).ToArray();
//  //  int[] mins = Enumerable.Range(0, x).Select(i => A[i].Min()).ToArray();
//  //  for (int i = 0; i < K; i++)
//  //  {
//  //    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//  //    int al = line[0] - 1, ar = line[1] - 1;
//  //    int amax = SquareSplitForMax(al, ar, x, A, maxs);
//  //    int amin = SquareSplitForMin(al, ar, x, A, mins);
//  //    int apoint = amax - amin;

//  //    int bl = line[2] - 1, br = line[3] - 1;
//  //    int bmax = SquareSplitForMax(bl, br, x, A, maxs);
//  //    int bmin = SquareSplitForMin(bl, br, x, A, mins);
//  //    int bpoint = bmax - bmin;

//  //    if (apoint > bpoint) { Console.WriteLine("A"); }
//  //    else if(apoint<bpoint) { Console.WriteLine("B"); }
//  //    else { Console.WriteLine(""); }
//  //  }
//  //}

//  //public static int SquareSplitForMax(int left, int right, int x, int[][] A, int[] maxs)
//  //{
//  //  int max = int.MinValue;
//  //  int index = left;
//  //  while (index <= right)
//  //  {
//  //    if (index % x == 0 && index + x <= right)
//  //    {
//  //      max = Math.Max(max, maxs[index / x]);
//  //      index += x;
//  //    }
//  //    else
//  //    {
//  //      max = Math.Max(max, A[index / x][index % x]);
//  //      index++;
//  //    }
//  //  }
//  //  return max;
//  //}

//  //public static int SquareSplitForMin(int left, int right, int x, int[][] A, int[] mins)
//  //{
//  //  int min = int.MaxValue;
//  //  int index = left;
//  //  while (index <= right)
//  //  {
//  //    if (index % x == 0 && index + x <= right)
//  //    {
//  //      min = Math.Min(min, mins[index / x]);
//  //      index += x;
//  //    }
//  //    else
//  //    {
//  //      min = Math.Min(min, A[index / x][index % x]);
//  //      index++;
//  //    }
//  //  }
//  //  return min;
//  //}
//}
