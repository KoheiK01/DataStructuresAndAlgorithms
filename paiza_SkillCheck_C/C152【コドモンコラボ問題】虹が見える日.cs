//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int DayMax = int.Parse(Console.ReadLine());
//    var weathers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//    List<int> days = new List<int>();
//    bool reinbow = false;
//    for (int day = 1; day < DayMax; day++)
//    {
//      if (weathers[day] == 0 && weathers[day - 1] == 2)
//      {
//        reinbow = true;
//        days.Add(day);

//      }
//    }
//    if (reinbow)
//    {
//      Console.WriteLine(string.Join(" ", days));
//    }
//    else
//    {
//      Console.WriteLine(-1);
//    }
//  }
//}