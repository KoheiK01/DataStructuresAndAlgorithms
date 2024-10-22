//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var _line = Console.ReadLine().Split();
//    int N = int.Parse(_line[0]);
//    int L = int.Parse(_line[1]);
//    List<int> U = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToList();
//    if (U.First() >= L)
//    {
//      U[0] = U[0] / 2;
//    }
//    Console.WriteLine(U.Sum());
//  }
//}