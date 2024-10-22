//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int c1 = int.Parse(words[1]);
//    int c2 = int.Parse(words[2]);

//    int stockNum = 0;
//    int money = 0;


//    for (int i = 0; i < n; i++)
//    {
//      int pi = int.Parse(Console.ReadLine());
//      if (i == n - 1)
//      {
//        money += pi * stockNum;
//        stockNum = 0;
//      }
//      else if (pi <= c1)
//      {
//        money -= pi;
//        stockNum++;
//      }
//      else if (pi >= c2)
//      {
//        money += pi * stockNum;
//        stockNum = 0;
//      }
//    }
//    Console.WriteLine(money);
//  }
//}