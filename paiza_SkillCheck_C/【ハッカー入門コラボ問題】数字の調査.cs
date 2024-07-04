//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int x = int.Parse(words[1]);

//    List<int> binary = new List<int>();
//    while (x != 0)
//    {
//      binary.Add(x % 2);
//      x /= 2;
//    }

//    for (int i = 0; i < n; i++)
//    {
//      int k = int.Parse(Console.ReadLine());
//      Console.WriteLine(binary[k - 1]);
//    }
//  }
//}