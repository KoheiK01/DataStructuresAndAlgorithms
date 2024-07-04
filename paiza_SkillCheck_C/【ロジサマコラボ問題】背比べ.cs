//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    double min = 100;
//    double max = 200;

//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      if (words[0] == "le")
//      {
//        max = Math.Min(double.Parse(words[1]), max);
//      }
//      else
//      {
//        min = Math.Max(double.Parse(words[1]), min);
//      }
//    }
//    Console.WriteLine(min.ToString("f1") + " " + max.ToString("f1"));
//  }
//}