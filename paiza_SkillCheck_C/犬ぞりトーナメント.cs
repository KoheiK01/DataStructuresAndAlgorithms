//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int p1 = int.Parse(words[0]);
//    int p2 = int.Parse(words[1]);
//    words = Console.ReadLine().Split(' ');
//    int p3 = int.Parse(words[0]);
//    int p4 = int.Parse(words[1]);

//    Dictionary<int, int> times = new Dictionary<int, int>();
//    words = Console.ReadLine().Split(' ');
//    for (int i = 1; i <= 4; i++)
//    {
//      int time = int.Parse(words[i - 1]);
//      times.Add(i, time);
//    }

//    int winner1 = p1;
//    if (times[p1] > times[p2])
//    {
//      winner1 = p2;
//    }

//    int winner2 = p3;
//    if (times[p3] > times[p4])
//    {
//      winner2 = p4;
//    }

//    words = Console.ReadLine().Split(' ');
//    int f1 = int.Parse(words[0]);
//    int f2 = int.Parse(words[1]);
//    if (winner1 < winner2)
//    {
//      times[winner1] = f1;
//      times[winner2] = f2;
//    }
//    else
//    {
//      times[winner2] = f1;
//      times[winner1] = f2;
//    }

//    int winner = winner1;
//    int subwinner = winner2;
//    if (times[winner1] > times[winner2])
//    {
//      winner = winner2;
//      subwinner = winner1;
//    }

//    Console.WriteLine(winner);
//    Console.WriteLine(subwinner);
//  }
//}