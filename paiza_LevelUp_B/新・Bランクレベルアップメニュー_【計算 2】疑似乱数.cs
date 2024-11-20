//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【計算 2】疑似乱数 **********/
//    //【計算 1】マンハッタン距離
//    //int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int px = line[0], py = line[1];
//    //int N = int.Parse(Console.ReadLine());
//    //List<int[]> points = new List<int[]>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  int x = input[0], y = input[1];
//    //  points.Add(new int[] { i, x, y });
//    //}
//    //// ユークリッド距離を計算
//    //var euclid = points
//    //    .Select(f => new int[] { f[0], (int)(Math.Pow(px - f[1], 2) + Math.Pow(py - f[2], 2)) })
//    //    .OrderBy(f => f[1])
//    //    .ThenBy(f => f[0])
//    //    .Take(3)
//    //    .Select(f => f[0])
//    //    .ToArray();
//    //var manhattan = points
//    //  .Select(f => new int[] { f[0], Math.Abs(px - f[1]) + Math.Abs(py - f[2]) })
//    //  .OrderBy(f => f[1])
//    //  .ThenBy(f => f[0])
//    //  .Take(3)
//    //  .Select(f => f[0])
//    //  .ToArray();
//    //foreach (var item in euclid)
//    //{
//    //  Console.WriteLine(item + 1);
//    //}
//    //foreach (var item in manhattan)
//    //{
//    //  Console.WriteLine(item + 1);
//    //}

//    //【計算 2】疑似乱数
//    //int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int X = line[0], M = line[1], N = line[2];
//    //int pow = 1;
//    //int seed = 0;
//    //for (int i = 1; i <= N; i++)
//    //{
//    //  pow *= X;
//    //  pow %= M;
//    //  seed += pow;
//    //  seed %= M;
//    //  Console.WriteLine(seed);
//    //}
//  }
//}