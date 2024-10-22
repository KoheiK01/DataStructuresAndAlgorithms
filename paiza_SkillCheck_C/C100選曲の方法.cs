//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int m = int.Parse(words[1]);
//    int s = int.Parse(words[2]);
//    int time = 60 * m + s;

//    List<int> singTimes = new List<int>();
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      m = int.Parse(words[0]);
//      s = int.Parse(words[1]);
//      singTimes.Add(60 * m + s);
//    }

//    singTimes = singTimes.OrderBy(x => x).ToList();

//    int ans = 0;
//    for (int i = 0; i < n; i++)
//    {
//      if (time - singTimes[i] >= 0)
//      {
//        time -= singTimes[i];
//        ans++;
//      }
//      else
//      {
//        break;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}