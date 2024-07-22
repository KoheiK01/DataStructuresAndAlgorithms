using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection.Emit;

class Program
{
  static void Main()
  {
    //自分の得意な言語で
    //Let's チャレンジ！！
    /********** 0 が含まれていないか判定 **********/
    //1問目
    //string S = Console.ReadLine();
    //string T = "paiza";
    //string result = S == T ? "YES" : "NO";
    //Console.WriteLine(result);
    //2問目
    //int N = int.Parse(Console.ReadLine());
    //string result = N <= 100 ? "YES" : "NO";
    //Console.WriteLine(result);
    //3問目
    //int[] ABC = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int A = ABC[0], B = ABC[1], C = ABC[2];
    //string result = A*B <= C ? "YES" : "NO";
    //Console.WriteLine(result);
    //4問目
    //int N = int.Parse(Console.ReadLine());
    //string result = N != 0 ? "YES" : "NO";
    //Console.WriteLine(result);
    //5問目
    //int N = int.Parse(Console.ReadLine());
    //string result = "YES";
    //for (int i = 0; i < N; i++)
    //{
    //  int a = int.Parse(Console.ReadLine());
    //  if (a == 0) { result = "NO"; break; }
    //}
    //Console.WriteLine(result);
    /********** AND+OR **********/
    //1・3問目
    //int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int A = AB[0], B = AB[1];
    //string result = A >= 10 && B >= 10 ? "YES" : "NO";
    //string result = A >= 10 || B >= 10 ? "YES" : "NO";
    //Console.WriteLine(result);
    //2問目
    //char C = Console.ReadLine()[0];
    //string result = char.IsUpper(C) ? "YES" : "NO";
    //Console.WriteLine(result);
    //4問目
    //int X = int.Parse(Console.ReadLine());
    //string result = X < 10 ? "YES" : "NO";
    //Console.WriteLine(result);
    //5問目
    //int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int A = AB[0], B = AB[1];
    //string result = A >= 10 && B < 10 ? "YES" : "NO";
    //Console.WriteLine(result);
    //6問目
    //int[] XYZ = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int X = XYZ[0], Y = XYZ[1], Z = XYZ[2];
    //string result = "";
    //if (Z == 10)
    //  result = "YES";
    //else
    //  result = X >= 10 && Y >= 10 ? "YES" : "NO";
    //Console.WriteLine(result);
    /********** FizzBuzz **********/
    //1～2問目
    //int N = int.Parse(Console.ReadLine());
    //string result = N % 3 == 0 ? "YES" : "NO";
    //string result = N % 3 == 0 && N % 5 == 0 ? "YES" : "NO";
    //Console.WriteLine(result);
    //3問目
    //int N = int.Parse(Console.ReadLine());
    //int E = 0, O = 0;
    //int[] As = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //for (int i = 0; i < N; i++)
    //{
    //  if (As[i] % 2 == 0) { E++; }
    //  else { O++; }
    //}
    //Console.WriteLine(E + " " + O);
    //4問目
    //int X = int.Parse(Console.ReadLine());
    //string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
    //string result = days[(X - 1) % 7];
    //Console.WriteLine(result);
    //5問目
    //int N = int.Parse(Console.ReadLine());
    //string result;
    //if (N % 3 == 0 && N % 5 == 0) { result = "FizzBuzz"; }
    //else if (N % 3 == 0) { result = "Fizz"; }
    //else if (N % 5 == 0) { result = "Buzz"; }
    //else { result = N.ToString(); }
    //Console.WriteLine(result);
    /********** 積の最小化 **********/
    //1問目
    //int N = int.Parse(Console.ReadLine());
    //int D = N.ToString().Length;
    //Console.WriteLine(D);
    //2問目
    //int[] NAB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int N = NAB[0], A = NAB[1], B = NAB[2];
    //string result = "NO";
    //if (N + A + B == 0) { result = "YES"; }
    //else if (N + A - B == 0) { result = "YES"; }
    //else if (N - A + B == 0) { result = "YES"; }
    //else if (N - A - B == 0) { result = "YES"; }
    //Console.WriteLine(result);
    //3問目
    //int N = int.Parse(Console.ReadLine());
    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //int[] Bs = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //int result = 0;
    //for (int i = 0; i < N; i++)
    //{
    //  if (As[i] == Bs[i]) { result++; }
    //}
    //Console.WriteLine(result);
    //4問目
    //int N = int.Parse(Console.ReadLine());
    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //int result = 0;
    //for (int i = 0; i < N; i++)
    //{
    //  if (As[i] % 2 == 0) { result += As[i]; }
    //  else { break; }
    //}
    //Console.WriteLine(result);
    //5問目
    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //int N = NK[0], K = NK[1];
    //int M = 1;
    //while ((N *= 2) < K)
    //{
    //  M++;
    //}
    //Console.WriteLine(M);
    //6～7問目
    //int[] NKT = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int N = NKT[0], K = NKT[1], T = NKT[2];
    //string result = K * T % N == 0 ? "YES" : "NO";
    //string result = K * N <= T ? "YES" : "NO";
    //Console.WriteLine(result);
    //8問目
    //int[] HW = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //int H = HW[0], W = HW[1];
    //string result = H % 2 == 0 && W % 2 == 0 ? "YES" : "NO";
    //result = H == 0 || W == 0 ? "NO" : result;
    //Console.WriteLine(result);
    //9問目
    int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int A = AB[0], B = AB[1];
    int result;
    if (A >= 0 && B >= 0) { result = A * A; }
    else if (A < 0 && B >= 0) { result = A * B; }
    else { result = B * B; }
    Console.WriteLine(result);
  }
}