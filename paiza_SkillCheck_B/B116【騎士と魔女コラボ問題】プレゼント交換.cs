//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int H = int.Parse(words[0]);
//    int W = int.Parse(words[1]);
//    int T = int.Parse(words[2]);
//    int X = 0, Y = 0;
//    int xChange = 1, yChange = 1;
//    string[] Male = new string[H + 1];
//    string[] Female = new string[W + 1];

//    for (int i = 1; i <= H; i++)
//      Male[i] = "M " + i;

//    for (int j = 1; j <= W; j++)
//      Female[j] = "F " + j;

//    for (int t = 0; t < T; t++)
//    {
//      string[,] Field = new string[H + 1, W + 1];
//      //男
//      if (X + xChange > W || X + xChange < 0)
//      {
//        xChange *= -1;
//      }
//      X += xChange;

//      for (int i = 1; i <= H; i++)
//      {
//        Field[i, X] = Male[i];
//      }

//      //女
//      if (Y + yChange > H || Y + yChange < 0)
//      {
//        yChange *= -1;
//      }
//      Y += yChange;

//      for (int j = 1; j <= W; j++)
//      {
//        if (Field[Y, j] != null)
//        {
//          string temp = Field[Y, j];
//          Male[Y] = Female[j];
//          Female[j] = temp;
//        }
//      }
//    }
//    for (int i = 1; i <= H; i++)
//      Console.WriteLine(Male[i]);

//    for (int j = 1; j <= W; j++)
//      Console.WriteLine(Female[j]);
//  }
//}
