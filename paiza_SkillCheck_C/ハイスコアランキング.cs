//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    var fLine = Console.ReadLine().Split(' ');
//    int N = int.Parse(fLine[0]);
//    int M = int.Parse(fLine[1]);
//    int K = int.Parse(fLine[2]);

//    double[] cs = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//    List<double> scores = new List<double>();
//    for (int i = 0; i < M; i++)
//    {
//      var items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//      double sum = 0;
//      for (int j = 0; j < N; j++)
//      {
//        sum += items[j] * cs[j];
//      }
//      sum = Math.Round(sum, MidpointRounding.AwayFromZero);
//      scores.Add(sum);
//    }

//    var topScores = scores.OrderByDescending(x => x).Take(K);
//    foreach (var score in topScores)
//    {
//      Console.WriteLine((int)score);
//    }
//  }
//}
