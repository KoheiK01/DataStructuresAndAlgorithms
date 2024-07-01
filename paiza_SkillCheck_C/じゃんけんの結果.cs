//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int n = int.Parse(words[0]);
//    int winCount = 0;
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split();
//      if (words[0] == "G" && words[1] == "C") winCount++;
//      else if (words[0] == "C" && words[1] == "P") winCount++;
//      else if (words[0] == "P" && words[1] == "G") winCount++;
//    }
//    Console.WriteLine(winCount);
//  }
//}