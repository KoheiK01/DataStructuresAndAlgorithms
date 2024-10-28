//using System;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 二重ループ：基本編　積の最大 **********/
//    //1～4問目
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int N = int.Parse(Console.ReadLine());
//    //Console.WriteLine(string.Join(" ", Enumerable.Range(1, N)));
//    //Console.WriteLine(string.Join("\n", Enumerable.Range(1, N)));
//    //Console.WriteLine(string.Join("\n", Enumerable.Repeat(string.Join(" ", Enumerable.Range(1, 5)), N)));
//    //Console.WriteLine(string.Join("\n", Enumerable.Repeat(string.Join(" ", Enumerable.Range(1, N)), K)));
//    //5～8問目
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[][] As = new int[N][];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //}
//    //int max = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //max = Math.Max(max, As[i].Max());
//    //Console.WriteLine(As[i].Sum());
//    //Console.WriteLine(string.Join(" ", As[i]));
//    //for (int j = 0; j < K; j++)
//    //{
//    //if (As[i][j] == 1)
//    //{
//    //  Console.WriteLine($"{i + 1} {j + 1}");
//    //  return;
//    //}
//    //}
//    //}
//    //Console.WriteLine(max);
//    //9問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] _words = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  Console.WriteLine(_words.Sum() - _words[0]);
//    //}
//    //
//    //10問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] _line = Enumerable.Range(1, i + 1).ToArray();
//    //  Console.WriteLine(string.Join(" ", _line));
//    //}
//    //11問目
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int max = -10000;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  for (int j = 0; j < K; j++)
//    //  {
//    //    max = Math.Max(max, A[i] * B[j]);
//    //  }
//    //}
//    //Console.WriteLine(max);

//    /********** 二重ループ：活用編 三角形の探索 **********/
//    //1問目
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0]; int K = NK[1];
//    //int[][] A = new int[N][];
//    //int[][] B = new int[N][];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  A[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //}

//    //for (int j = 0; j < K; j++)
//    //{
//    //  for (int i = 0; i < N; i++)
//    //  {
//    //    if (i == N - 1)
//    //    {
//    //      Console.WriteLine(A[i][j]);
//    //    }
//    //    else
//    //    {
//    //      Console.Write(A[i][j] + " ");
//    //    }
//    //  }
//    //}
//    //2問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //string[] result = Enumerable.Range(0, N)
//    //    .Select(i => string.Join(" ", A.Select(a => a * A[i]))).ToArray();
//    //Console.WriteLine(string.Join("\n", result));
//    //3問目
//    //int N = int.Parse(Console.ReadLine());
//    //int ans = 0;
//    //for (int i = 2; i <= N; i++)
//    //{
//    //  bool isPrime = true;
//    //  for (int j = 2; j * j <= i; j++)
//    //  {
//    //    if (i % j == 0)
//    //    {
//    //      isPrime = false;
//    //      break;
//    //    }
//    //  }
//    //  if (isPrime)
//    //  {
//    //    ans++;
//    //  }
//    //}
//    //Console.WriteLine(ans);
//    //4問目
//    //int N = int.Parse(Console.ReadLine());
//    //int ans = 0;
//    //while (N >= 2)
//    //{
//    //  ans += N / 2;
//    //  N /= 2;
//    //}
//    //Console.WriteLine(ans);
//    //5問目
//    //for (int h = 0; h < 24; h++)
//    //{
//    //  for (int m = 0; m < 60; m++)
//    //  {
//    //    if ((h + m) % 15 == 0)
//    //    {
//    //      Console.WriteLine("FIZZBUZZ");
//    //    }
//    //    else if ((h + m) % 3 == 0)
//    //    {
//    //      Console.WriteLine("FIZZ");
//    //    }
//    //    else if ((h + m) % 5 == 0)
//    //    {
//    //      Console.WriteLine("BUZZ");
//    //    }
//    //    else
//    //    {
//    //      Console.WriteLine();
//    //    }
//    //  }
//    //}
//    //6問目
//    //int ans = 0;
//    //for (int i = 1; i < 99; i++)
//    //{
//    //  for (int j = 1; i + j < 100; j++)
//    //  {
//    //    if (Math.Pow(i, 3) + Math.Pow(j, 3) < 100000 && i * j > ans)
//    //    {
//    //      ans = i * j;
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(ans);
//    //7問目
//    //int[] XYZ = Console.ReadLine().Split().Select(int.Parse).ToArray();

//    //int ans = 3000;
//    //int X = XYZ[0], Y = XYZ[1], Z = XYZ[2];
//    //for (int i = 0; i * X <= Z; i++)
//    //{
//    //  for (int j = 0; i * X + j * Y <= Z; j++)
//    //  {
//    //    int money = i * X + j * Y;
//    //    ans = Math.Min(Z - money + i + j, ans);
//    //  }
//    //}
//    //Console.WriteLine(ans);
//    //8問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int a = (int)Math.Ceiling((double)N / 3) + 1; a < N - 1; a++)
//    //{
//    //  for (int b = 1; b < N - a; b++)
//    //  {
//    //    int c = N - a - b;
//    //    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
//    //    {
//    //      Console.WriteLine("YES");
//    //      return;
//    //    }
//    //  }
//    //}
//    //Console.WriteLine("NO");
//  }
//}