//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int spotMax = int.Parse(Console.ReadLine());
//    var stayTimes = new int[spotMax];
//    var moveTimes = new int[spotMax, spotMax];

//    for (int i = 0; i < spotMax; i++)
//    {
//      stayTimes[i] = int.Parse(Console.ReadLine());
//    }
//    for (int i = 0; i < spotMax; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      for (int j = 0; j < spotMax; j++)
//      {
//        moveTimes[i, j] = int.Parse(words[j]);
//      }
//    }

//    int goMax = int.Parse(Console.ReadLine());
//    var gotoSpots = new int[goMax];
//    for (int i = 0; i < goMax; i++)
//    {
//      gotoSpots[i] = int.Parse(Console.ReadLine()) - 1;
//    }

//    int ans = stayTimes[gotoSpots[0]];
//    for (int i = 1; i < goMax; i++)
//    {
//      ans += moveTimes[gotoSpots[i - 1], gotoSpots[i]];
//      ans += stayTimes[gotoSpots[i]];
//    }
//    Console.WriteLine(ans);
//  }
//}