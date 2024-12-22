//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int personNum = int.Parse(words[0]);
//    int songLen = int.Parse(words[1]);
//    int[] songAns = new int[songLen];

//    for (int i = 0; i < songLen; i++)
//    {
//      int input = int.Parse(Console.ReadLine());
//      songAns[i] = input;
//    }

//    int maxPoint = 0;
//    for (int person = 0; person < personNum; person++)
//    {
//      int personPoint = 100;
//      for (int part = 0; part < songLen; part++)
//      {
//        int input = int.Parse(Console.ReadLine());
//        int error = Math.Abs(input - songAns[part]);
//        if (error <= 5)
//          personPoint -= 0;
//        else if (5 < error && error <= 10)
//          personPoint -= 1;
//        else if (error <= 20)
//          personPoint -= 2;
//        else if (error <= 30)
//          personPoint -= 3;
//        else
//          personPoint -= 5;
//      }
//      maxPoint = Math.Max(maxPoint, personPoint);
//    }

//    Console.WriteLine(maxPoint);
//  }
//}