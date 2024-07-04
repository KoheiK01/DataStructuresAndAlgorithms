//using System;
//using System.Management.Instrumentation;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int m = int.Parse(words[0]);
//    int d = int.Parse(words[1]);

//    words = Console.ReadLine().Split(' ');
//    int p = int.Parse(words[0]);
//    int n = int.Parse(words[1]);

//    int money = 0;

//    int sarvice = n / m;
//    money += sarvice * m * p * (100 - d) / 100;
//    int normal = n % m;
//    money += normal * p;
//    Console.WriteLine(money);
//  }
//}