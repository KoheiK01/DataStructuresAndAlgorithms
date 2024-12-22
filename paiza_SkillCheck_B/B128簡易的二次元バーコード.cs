//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string N = Console.ReadLine();
//    List<char[,]> maps = new List<char[,]>();

//    for (int i = 0; i < N.Length; i++)
//    {
//      char[,] map = new char[3, 3];
//      map = ChangeToMap(int.Parse(N[i].ToString()));
//      maps.Add(map);
//    }

//    for (int i = 0; i < N.Length / 3; i++)
//    {
//      for (int height = 0; height < 3; height++)
//      {
//        for (int wide = 0; wide < 9; wide++)
//        {
//          if (wide < 3)
//            Console.Write(maps[i * 3][height, wide]);

//          else if (wide < 6)
//            Console.Write(maps[i * 3 + 1][height, wide - 3]);

//          else
//            Console.Write(maps[i * 3 + 2][height, wide - 6]);
//        }
//        Console.WriteLine();
//      }
//    }
//  }

//  static char[,] ChangeToMap(int number)
//  {
//    char[,] map = new char[3, 3];
//    int count = 0;

//    for (int height = 0; height < 3; height++)
//    {
//      for (int wide = 0; wide < 3; wide++)
//      {
//        if (number > count)
//          map[height, wide] = '#';
//        else
//          map[height, wide] = '.';
//        count++;
//      }
//    }

//    return map;
//  }
//}