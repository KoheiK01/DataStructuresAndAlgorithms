//using System;
//using System.Dynamic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int l = int.Parse(Console.ReadLine());
//    var words = Console.ReadLine().Split(' ');
//    int u = int.Parse(words[0]);
//    int a = int.Parse(words[1]);
//    int b = int.Parse(words[2]);
//    int v = int.Parse(Console.ReadLine());

//    double kameTime = (double)l * v;
//    int usagiTime = 0;

//    for (int i = 1; i <= l; i++)
//    {
//      usagiTime += u;
//      if (i % a == 0 && i != l)
//      {
//        usagiTime += b;
//      }
//    }

//    if (usagiTime < kameTime)
//    {
//      Console.WriteLine("USAGI");
//    }
//    else if (usagiTime == kameTime)
//    {
//      Console.WriteLine("DRAW");
//    }
//    else
//    {
//      Console.WriteLine("KAME");
//    }
//  }
//}