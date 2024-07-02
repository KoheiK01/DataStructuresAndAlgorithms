//using System;
//using System.Runtime.InteropServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());

//    int[] a = new int[n];

//    var words = Console.ReadLine().Split(' ');
//    for (int i = 0; i < n; i++)
//    {
//      int ai = int.Parse(words[i]);
//      a[i] = ai;
//    }

//    words = Console.ReadLine().Split(' ');
//    int money = int.Parse(words[0]);
//    int order = int.Parse(words[1]);
//    for (int i = 0; i < order; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int kind = int.Parse(words[0]) - 1;
//      int num = int.Parse(words[1]);
//      int need = a[kind] * num;
//      if (need <= money)
//      {
//        money -= need;
//      }
//    }
//    Console.WriteLine(money);
//  }
//}