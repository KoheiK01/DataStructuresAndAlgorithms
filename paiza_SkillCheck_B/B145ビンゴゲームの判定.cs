using System;
using System.Linq;
class Program
{
  static void Main()
  {
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int N = NK[0], K = NK[1];
    int[,] bingoCard = new int[N, N];
    for (int i = 0; i < N; i++)
    {
      int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
      for (int j = 0; j < N; j++)
      {
        bingoCard[i, j] = row[j];
      }
    }
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    bool[,] opened = new bool[N, N];
    for (int row = 0; row < N; row++)
    {
      for (int col = 0; col < N; col++)
      {
        if (bingoCard[row, col] == 0 || nums.Contains(bingoCard[row, col]))
        {
          opened[row, col] = true;
        }
      }
    }

    int bingoCount = 0;
    for (int row = 0; row < N; row++)
    {
      if (Enumerable.Range(0, N).All(col => opened[row, col]))
      {
        bingoCount++;
      }
    }

    for (int col = 0; col < N; col++)
    {
      if (Enumerable.Range(0, N).All(row => opened[row, col]))
      {
        bingoCount++;
      }
    }

    if (Enumerable.Range(0, N).All(i => opened[i, i]))
    {
      bingoCount++;
    }

    if (Enumerable.Range(0, N).All(i => opened[N - 1 - i, i]))
    {
      bingoCount++;
    }

    Console.WriteLine(bingoCount);
  }
}