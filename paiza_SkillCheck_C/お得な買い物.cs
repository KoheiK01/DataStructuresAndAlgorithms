//using System;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    int[] sums = new int[4];
//    int[] rates = new int[4]
//    {
//      5,3,2,1
//    };
//    int n = int.Parse(Console.ReadLine());
//    for (int i = 0; i < n; i++)
//    {
//      string[] words = Console.ReadLine().Split();
//      int v = int.Parse(words[0]);
//      int p = int.Parse(words[1]);
//      sums[v] += p;
//    }

//    int pointSum = 0;
//    for (int i = 0; i < 4; i++)
//    {
//      pointSum += sums[i] / 100 * rates[i];
//    }
//    Console.WriteLine(pointSum);
//  }
//}