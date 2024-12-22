//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());

//    List<int> list = new List<int>();
//    bool check;
//    int a1 = int.Parse(Console.ReadLine());
//    Console.WriteLine(0);
//    list.Add(a1);

//    for (int i = 1; i < N; i++)
//    {
//      //挿入
//      int ai = int.Parse(Console.ReadLine());
//      int index;
//      check = false;

//      for (index = 0; index < list.Count; index++)
//      {
//        if (list[index] <= ai)
//        {
//          if (list[index] == ai)
//          {
//            check = true;
//          }
//          break;
//        }
//      }

//      list.Insert(index, ai);

//      Console.WriteLine(index);

//      if (check)
//      {
//        do
//        {
//          list[index] *= 2;
//          list.RemoveAt(index + 1);
//          if (index == 0 || list[index - 1] != list[index])
//          {
//            break;
//          }
//          index--;
//        } while (true);
//      }
//    }
//  }
//}
