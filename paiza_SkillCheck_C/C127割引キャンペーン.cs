//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int N = int.Parse(words[0]);
//    int M = int.Parse(words[1]);
//    string[] names = new string[M];
//    for (int i = 0; i < M; i++)
//    {
//      names[i] = Console.ReadLine();
//    }

//    List<string> list = new List<string>();
//    for (int i = 0; i < M; i++)
//    {
//      if (i + 1 <= M - N)
//      {
//        if (!list.Contains(names[i]))
//        {
//          list.Add(names[i]);
//        }
//      }
//      else if (list.Contains(names[i]))
//      {
//        list.Remove(names[i]);
//      }
//    }
//    Console.WriteLine(list.Count);

//  }
//}