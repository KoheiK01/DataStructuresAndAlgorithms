//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int a = int.Parse(words[1]);
//    int b = int.Parse(words[2]);

//    string sn = Console.ReadLine();
//    string sa = Console.ReadLine();
//    string sb = Console.ReadLine();

//    int aindex = 0;
//    int bindex = 0;

//    for (int i = 0; i < n; i++)
//    {
//      char direction = sn[i];
//      if (aindex != a)
//      {
//        if (direction == sa[aindex])
//        {
//          aindex++;
//        }
//      }

//      if (bindex != b)
//      {
//        if (direction == sb[bindex])
//        {
//          bindex++;
//        }
//      }
//    }
//    Console.WriteLine(a - aindex + " " + (b - bindex));
//  }
//}