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
//    int R = int.Parse(words[2]);
//    int n = int.Parse(Console.ReadLine());

//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int x = int.Parse(words[0]);
//      int y = int.Parse(words[1]);
//      if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) >= R * R)
//      {
//        Console.WriteLine("silent");
//      }
//      else
//      {
//        Console.WriteLine("noisy");
//      }
//    }
//  }
//}