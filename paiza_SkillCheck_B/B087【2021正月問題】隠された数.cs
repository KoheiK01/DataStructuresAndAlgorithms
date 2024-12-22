//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static int count = 0;
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int h = int.Parse(words[0]);
//    int w = int.Parse(words[1]);
//    int k = int.Parse(words[2]);

//    int[,] maps = new int[h, w];

//    for (int i = 0; i < h; i++)
//    {
//      string line = Console.ReadLine();
//      for (int j = 0; j < w; j++)
//      {
//        int temp = int.Parse(line[j].ToString());
//        maps[i, j] = temp;
//      }
//    }

//    List<int> list = new List<int>();
//    for (int i = 0; i < h - k + 1; i++)
//    {
//      for (int j = 0; j < w; j++)
//      {
//        string temp1 = "";
//        for (int keta = 0; keta < k; keta++)
//        {
//          temp1 += maps[i + keta, j].ToString();
//        }
//        list.Add(int.Parse(temp1));
//      }
//    }

//    int max1 = list.Max();
//    list.Clear();

//    for (int j = 0; j < w - k + 1; j++)
//    {
//      for (int i = 0; i < h; i++)
//      {
//        string temp2 = "";
//        for (int keta = 0; keta < k; keta++)
//        {
//          temp2 += maps[i, j + keta].ToString();
//        }
//        list.Add(int.Parse(temp2));
//      }
//    }

//    int max2 = list.Max();
//    Console.WriteLine(Math.Max(max1, max2));

//  }
//}
