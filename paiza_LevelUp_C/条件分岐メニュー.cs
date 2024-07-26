//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Net;
//using System.Reflection.Emit;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** a ~ z までを表示 **********/
//    //1～7問目
//    //int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int N = int.Parse(Console.ReadLine());
//    //var A = Enumerable.Range(1, N).ToArray();
//    //char[] A = Enumerable.Range('a', 26).Select(i => (char)i).ToArray();
//    //var A = Enumerable.Repeat(N, K).ToArray();
//    //var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Console.WriteLine(string.Join("\n", A));
//    /********** 数列同士の引き算 **********/
//    //1～4問目
//    //var NAB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int N = NAB[0], A = NAB[1], B = NAB[2];
//    //int N = int.Parse(Console.ReadLine());
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //var Bs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //Zipメソッドを使用すれば簡潔に書ける!!!
//    //As = As.Zip(Bs, (a, b) => a - b).ToArray();
//    //As = As.Select(i => i * 2).ToArray();
//    //SkipとTakeは使いこなせば武器になる!!!
//    //Console.WriteLine(As.Skip(A - 1).Take(B - A + 1).Sum());
//    //Console.WriteLine(As.Sum());
//    //Console.WriteLine(string.Join("\n", As));
//    /********** FizzBuzz **********/
//    //1～4問目
//    //int N = int.Parse(Console.ReadLine());
//    //var As = Enumerable.Range(1, 9).Select(i => i * N).ToList();
//    //var As = Enumerable.Range(1, N).Select(i => Math.Pow(2, i)).ToList();
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//    //As.Reverse();
//    //Console.WriteLine(string.Join("\n", As));
//    //Console.WriteLine(string.Join(" ", As));
//    //5問目
//    //string[] As = Enumerable.Range(1, 100).Select(i => i.ToString()).ToArray();
//    //for (int i = 3; i <= 100; i += 3) { As[i - 1] = "Fizz"; }
//    //for (int i = 5; i <= 100; i += 5) { As[i - 1] = "Buzz"; }
//    //for (int i = 15; i <= 100; i += 15) { As[i - 1] = "FizzBuzz"; }
//    //Console.WriteLine(string.Join("\n", As));
//    /********** 数列の中に何個ある? **********/
//    //1～4問目
//    //int N = int.Parse(Console.ReadLine());
//    //var As = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//    //Console.WriteLine(As.Max());
//    //Console.WriteLine(As.Min());
//    //Console.WriteLine(As.IndexOf(1) + 1);
//    //Console.WriteLine(As.Count(i => i == 1));
//  }
//}