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
    /********** 二重ループ：基本編　積の最大 **********/
    //1～4問目
    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
    //int N = NK[0], K = NK[1];
    //int N = int.Parse(Console.ReadLine());
    //Console.WriteLine(string.Join(" ", Enumerable.Range(1, N)));
    //Console.WriteLine(string.Join("\n", Enumerable.Range(1, N)));
    //Console.WriteLine(string.Join("\n", Enumerable.Repeat(string.Join(" ", Enumerable.Range(1, 5)), N)));
    //Console.WriteLine(string.Join("\n", Enumerable.Repeat(string.Join(" ", Enumerable.Range(1, N)), K)));
    //5問目
    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int N = NK[0], K = NK[1];
    int[][] As = new int[N][];
    for (int i = 0; i < N; i++)
    {
      As[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
    }
    for (int i = 0; i < N; i++)
    {
      Console.WriteLine(string.Join(" ", As[i]));
    }
  }
}