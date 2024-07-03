using System;
using System.Linq;
using System.Linq.Expressions;
class Program
{
  static void Main()
  {
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int n = int.Parse(Console.ReadLine());
    int[] x = new int[n];
    for (int i = 0; i < n; i++)
    {
      x[i] = int.Parse(Console.ReadLine());
    }

    int upperCount = 0;
    int downCount = 0;
    int upperMax = 0;
    int downMax = 0;
    for (int i = 1; i < n; i++)
    {
      if (x[i] < x[i - 1])
      {
        upperMax = Math.Max(upperCount, upperMax);
        upperCount = 0;
        downCount++;
      }
      else
      {
        downMax = Math.Max(downCount, downMax);
        downCount = 0;
        upperCount++;
      }
    }
    downMax = Math.Max(downCount, downMax);
    upperMax = Math.Max(upperCount, upperMax);

    Console.WriteLine(downMax + " " + upperMax);
  }
}