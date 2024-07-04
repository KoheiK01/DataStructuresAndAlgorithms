//using System;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int h = int.Parse(words[0]);
//    int w = int.Parse(words[1]);

//    int[,] sums = new int[h, w];
//    for (int i = 0; i < h; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      for (int j = 0; j < w; j++)
//      {
//        sums[i, j] = int.Parse(words[j]);
//      }
//    }

//    int h3 = h / 3;
//    int w3 = w / 3;
//    int[,] aves = new int[h3, w3];

//    for (int hcount = 0; hcount < h3; hcount++)
//    {
//      for (int wcount = 0; wcount < w3; wcount++)
//      {
//        for (int i = 0; i < 3; i++)
//        {
//          for (int j = 0; j < 3; j++)
//          {
//            aves[hcount, wcount] += sums[hcount * 3 + i, wcount * 3 + j];
//          }
//        }
//        aves[hcount, wcount] /= 9;
//        if (wcount == w3 - 1)
//        {
//          Console.WriteLine(aves[hcount, wcount]);
//        }
//        else
//        {
//          Console.Write(aves[hcount, wcount] + " ");
//        }
//      }
//    }
//  }
//}