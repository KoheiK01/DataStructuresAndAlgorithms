//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int[] starts = new int[n];
//    int[] ends = new int[n];
//    int[] highs = new int[n];
//    int[] lows = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      starts[i] = int.Parse(words[0]);
//      ends[i] = int.Parse(words[1]);
//      highs[i] = int.Parse(words[2]);
//      lows[i] = int.Parse(words[3]);
//    }
//    int[] anss = new int[4];
//    anss[0] = starts[0];
//    anss[1] = ends.Last();
//    anss[2] = highs.Max();
//    anss[3] = lows.Min();
//    Console.WriteLine(string.Join(" ", anss));
//  }
//}