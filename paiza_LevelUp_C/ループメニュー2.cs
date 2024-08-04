//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Net;
//using System.Reflection.Emit;
//using System.Security.Cryptography;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 偶奇の判定 **********/
//    //1～2問目
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//    //var As = Console.ReadLine().Split(' ').ToList();
//    //foreach (var item in As)
//    //{
//    //  Console.WriteLine(item);
//    //if (item == -1) break;
//    //  if (item == "EOF") break;
//    //}
//    //3～4問目
//    //int N = int.Parse(Console.ReadLine());
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//    //As = As.Where(a => a % 3 == 0).ToList();
//    //As = As.Where(a => a % 2 == 1).ToList();
//    //Console.WriteLine(string.Join("\n", As));
//    //5問目
//    //int N = int.Parse(Console.ReadLine());
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//    //foreach (var item in As)
//    //{
//    //  if (item % 2 == 0) Console.WriteLine("even");
//    //  else Console.WriteLine("odd");
//    //}
//    /********** 約数の列挙 **********/
//    //1問目
//    //string N = Console.ReadLine();
//    //int result = N.ToCharArray().Select(i => int.Parse(i.ToString())).Sum();
//    //Console.WriteLine(result);
//    //2問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] Ms = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Ms[i] * (i + 1));
//    //}
//    //3～4問目
//    //int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = int.Parse(Console.ReadLine());
//    //int N = NM[0], M = NM[1];
//    //int result = 0;
//    //while (N % M == 0)
//    //{
//    //  N /= M;
//    //  result++;
//    //}
//    //Console.WriteLine(result);
//    //5～6問目
//    //int[] NM = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NM[0], M = NM[1];
//    //int N = int.Parse(Console.ReadLine());
//    //string result = "";
//    //while (N != 0)
//    //{
//    //  int degit = N % M;
//    //  N /= M;
//    //  result = degit + result;
//    //}
//    //Console.WriteLine(result);
//    //7問目
//    //int[] NMK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NMK[0], M = NMK[1], K = NMK[2];
//    //int result = 0;
//    //while (N <= K)
//    //{
//    //  result++;
//    //  N += M;
//    //}
//    //Console.WriteLine(result);
//    //8問目
//    //int[] AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = AB[0], B = AB[1];
//    //int result = 0;
//    //while (A <= B)
//    //{
//    //  result++;
//    //  A += A / 10;
//    //}
//    //Console.WriteLine(result);
//    //9問目
//    //int N = int.Parse(Console.ReadLine());
//    //int result = 1;
//    //for (int i = 1; i <= N; i++)
//    //{
//    //  result *= i;
//    //}
//    //Console.WriteLine(result);
//    ////10問目
//    //int N = int.Parse(Console.ReadLine());
//    //int result = 0;
//    //while (N / 5 >= 1)
//    //{
//    //  result += N /= 5;
//    //}
//    //Console.WriteLine(result);
//    //11～12問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  As[i] += i + 1;
//    //}
//    //Console.WriteLine(As.Max());
//    //Console.WriteLine(As.Min());
//    //13問目
//    //int N = int.Parse(Console.ReadLine());
//    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  if (As[i] == 1)
//    //  {
//    //    Console.WriteLine(i + 1);
//    //  }
//    //}
//    //14～15問目
//    //int N = int.Parse(Console.ReadLine());
//    //List<int> divCounts = new List<int>();
//    //for (int i = 1; i * i <= N; i++)
//    //{
//    //  if (N % i == 0)
//    //  {
//    //    divCounts.Add(i);
//    //    if (i * i != N)
//    //    {
//    //      divCounts.Add(N / i);
//    //    }
//    //  }
//    //}
//    //divCounts.Sort();
//    //Console.WriteLine(string.Join("\n", divCounts));
//    //Console.WriteLine(divCounts.Count);
//  }
//}