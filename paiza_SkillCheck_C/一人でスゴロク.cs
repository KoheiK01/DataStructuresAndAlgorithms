//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int N = int.Parse(words[0]);
//    int M = int.Parse(words[1]);

//    string[] effect = new string[N];
//    for (int i = 1; i <= N - 2; i++)
//    {
//      effect[i] = Console.ReadLine();
//    }

//    int goal = 0;
//    string ans = "still";
//    int now = 0;
//    for (int i = 1; i <= M; i++)
//    {
//      int saikoro = int.Parse(Console.ReadLine());
//      now += saikoro;
//      if (now >= N - 1)
//      {
//        goal = i;
//        ans = "goal";
//        break;
//      }
//      else
//      {
//        switch (effect[now])
//        {
//          case "+":
//            now++;
//            break;
//          case "-":
//            now--;
//            break;
//          case "r":
//            now = 0;
//            break;
//          case "x":
//            break;
//        }
//      }
//    }

//    Console.WriteLine(ans.ToString());
//    if (ans == "goal")
//    {
//      Console.WriteLine(goal);
//    }
//    else
//    {
//      Console.WriteLine(now);
//    }
//  }
//}