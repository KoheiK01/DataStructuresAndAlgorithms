//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int N = int.Parse(words[0]);
//    int M = int.Parse(words[1]);
//    int K = int.Parse(words[2]);
//    List<int> Cards = new List<int>();
//    List<int> SortedCards = new List<int>();
//    for (int i = 0; i < N; i++)
//      Cards.Add(i + 1);

//    for (int i = 0; i < K; i++)
//    {
//      int lastSet = N % M;
//      if (lastSet != 0)
//        SortedCards.AddRange(Cards.GetRange(N / M * M, lastSet));

//      for (int j = N / M - 1; j >= 0; j--)
//        SortedCards.AddRange(Cards.GetRange(j * M, M));

//      Cards = SortedCards.ToList();
//      SortedCards.Clear();
//    }

//    Console.WriteLine(String.Join("\n", Cards));
//  }
//}
