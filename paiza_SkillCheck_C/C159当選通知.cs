//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int N = NK[0], K = NK[1];
//    int[] w = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    SortedSet<int> winning = new SortedSet<int>();
//    for (int i = 0; i < K; i++)
//    {
//      if (w.Contains(v[i]))
//      {
//        winning.Add(i + 1);
//      }
//    }
//    if (winning.Count > 0)
//    {
//      Console.WriteLine(string.Join("\n", winning));
//    }
//    else
//    {
//      Console.WriteLine(-1);
//    }
//  }
//}
