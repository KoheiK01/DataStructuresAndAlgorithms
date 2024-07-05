//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int v = int.Parse(words[1]);
//    int[] times = new int[n];
//    int[] ps = new int[n];

//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      times[i] = int.Parse(words[0]);
//      ps[i] = int.Parse(words[1]);
//    }

//    string ans = "NO";
//    for (int i = 0; i < n - 1; i++)
//    {
//      for (int j = i + 1; j < n; j++)
//      {
//        int speed = (ps[j] - ps[i]) / (times[j] - times[i]);
//        if (speed > v)
//        {
//          ans = "YES";
//          break;
//        }
//      }
//      if (ans == "YES")
//      {
//        break;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}