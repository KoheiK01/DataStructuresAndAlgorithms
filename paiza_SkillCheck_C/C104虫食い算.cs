//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int a = int.Parse(words[0]);
//    int b = int.Parse(words[1]);

//    int baseRight = 100 * a + b;
//    string ans = "No";
//    for (int x = 0; x < 10; x++)
//    {
//      for (int y = 0; y < 10; y++)
//      {
//        int left = (10 * x + y) * y;
//        int right = baseRight + 10 * x;
//        if (left == right)
//        {
//          ans = x + " " + y;
//          break;
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}