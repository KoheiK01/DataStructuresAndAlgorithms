//using System;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());

//    int[] counts = new int[4];
//    for (int i = 0; i < n; i++)
//    {
//      string s = Console.ReadLine();
//      for (int j = 0; j < 4; j++)
//      {
//        counts[j] += int.Parse(s[j].ToString());
//      }
//    }

//    for (int i = 0; i < 4; i++)
//    {
//      if (counts[i] % 2 == 0)
//      {
//        Console.Write(0);
//      }
//      else
//      {
//        Console.Write(1);
//      }
//    }
//  }
//}