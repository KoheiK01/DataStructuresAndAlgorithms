//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string[] words;

//    Dictionary<string, int> timeDiffs = new Dictionary<string, int>();
//    int n = int.Parse(Console.ReadLine());
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      timeDiffs.Add(words[0], int.Parse(words[1]));
//    }

//    words = Console.ReadLine().Split();
//    int diff = timeDiffs[words[0]];
//    string[] spotTime = words[1].Split(':');
//    int spotHour = int.Parse(spotTime[0]);
//    int standardHour = spotHour - diff;

//    foreach (var item in timeDiffs)
//    {
//      int hour = standardHour + item.Value;
//      if (hour >= 24)
//      {
//        hour -= 24;
//      }
//      else if (hour < 0)
//      {
//        hour += 24;
//      }
//      Console.WriteLine(hour.ToString("00") + ":" + spotTime[1]);
//    }
//  }
//}