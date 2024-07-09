//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int M = int.Parse(words[0]);
//    int N = int.Parse(words[1]);

//    int maxNum = int.MinValue;
//    int minAmari = int.MaxValue;
//    int bestMac = 0;

//    for (int i = 0; i < M; i++)
//    {
//      int mi = int.Parse(Console.ReadLine());
//      int okashiNum = N / mi;
//      int amari = N - okashiNum * mi;
//      if (amari <= minAmari)
//      {
//        if (amari < minAmari)
//        {
//          minAmari = amari;
//          maxNum = int.MinValue;
//        }
//        if (mi > maxNum)
//        {
//          maxNum = mi;
//          bestMac = i + 1;
//        }
//      }
//    }
//    Console.WriteLine(bestMac);
//  }
//}
