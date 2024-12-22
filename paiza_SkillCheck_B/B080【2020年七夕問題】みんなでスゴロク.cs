//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int MathMax = int.Parse(words[0]);
//    int PlayerMax = int.Parse(words[1]);
//    int TurnMax = int.Parse(words[2]);
//    int[] NowMathes = new int[PlayerMax];
//    int[] HasCoins = new int[PlayerMax];
//    int[] GoalRank = new int[PlayerMax];
//    int goalCount = 0;

//    int[,] effects = new int[MathMax, 2];
//    for (int i = 1; i < MathMax - 1; i++)
//    {
//      words = Console.ReadLine().Split();
//      effects[i, 0] = int.Parse(words[0]);
//      effects[i, 1] = int.Parse(words[1]);
//    }

//    for (int turn = 0; turn < TurnMax; turn++)
//    {
//      words = Console.ReadLine().Split();
//      for (int player = 0; player < PlayerMax; player++)
//      {
//        int saikoro = int.Parse(words[player]);
//        NowMathes[player] += saikoro;

//        //ゴールしていない人の移動とコインの操作
//        if (GoalRank[player] == 0)
//        {
//          //もしゴールしていたら
//          if (NowMathes[player] >= MathMax - 1)
//          {
//            goalCount++;
//            GoalRank[player] = goalCount;
//          }

//          //コインと移動に関する操作
//          else
//          {
//            //まずはコイン
//            HasCoins[player] += effects[NowMathes[player], 1];
//            HasCoins[player] = Math.Max(0, HasCoins[player]);

//            //移動に関する操作
//            if (NowMathes[player] + effects[NowMathes[player], 0] <= 0)
//            {
//              NowMathes[player] = 0;
//            }
//            else if (NowMathes[player] + effects[NowMathes[player], 0] >= MathMax - 1)
//            {
//              goalCount++;
//              GoalRank[player] = goalCount;
//            }
//            else
//            {
//              NowMathes[player] += effects[NowMathes[player], 0];
//            }
//          }
//        }

//        //ゴールしている人のコインに関する操作
//        else
//        {
//          if (GoalRank[player] == 1)
//            HasCoins[player] += 3 * saikoro;
//          else if (GoalRank[player] == 2)
//            HasCoins[player] += 2 * saikoro;
//          else if (GoalRank[player] == 3)
//            HasCoins[player] += saikoro;
//        }
//      }
//    }

//    int maxCoin = HasCoins.Max();
//    for (int player = 0; player < PlayerMax; player++)
//    {
//      if (maxCoin == HasCoins[player])
//      {
//        Console.WriteLine(player + 1 + " " + maxCoin);
//        break;
//      }
//    }
//  }
//}
