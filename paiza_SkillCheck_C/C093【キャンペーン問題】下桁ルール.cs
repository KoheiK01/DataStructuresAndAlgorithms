//using System;
//using System.Linq;
//using System.Runtime.ExceptionServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    var bmark = words[0];
//    var amark = words[1];
//    int bSum = 0;
//    int aSum = 0;

//    for (int i = 0; i < bmark.Length; i++)
//    {
//      bSum += int.Parse(bmark[i].ToString());
//    }
//    for (int i = 0; i < amark.Length; i++)
//    {
//      aSum += int.Parse(amark[i].ToString());
//    }

//    int bScore = bSum % 10;
//    int aScore = aSum % 10;

//    if (bScore > aScore)
//    {
//      Console.WriteLine("Bob");
//    }
//    else if (bScore == aScore)
//    {
//      Console.WriteLine("Draw");
//    }
//    else
//    {
//      Console.WriteLine("Alice");
//    }
//  }
//}