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
//    int inputNum = int.Parse(words[0]);
//    int blockLen = int.Parse(words[1]);

//    string s = Console.ReadLine();
//    int blockNum = (int)Math.Ceiling((double)inputNum / blockLen);
//    string[] blocks = new string[blockNum];

//    for (int bi = 0; bi < blockNum; bi++)
//    {
//      for (int i = 0; i < blockLen; i++)
//      {
//        if (bi * blockLen + i < inputNum)
//        {
//          blocks[bi] += s[bi * blockLen + i];
//        }
//        else
//        {
//          blocks[bi] += "0";
//        }
//      }
//    }

//    string ans = "";
//    for (int i = 0; i < blockLen; i++)
//    {
//      char keta = blocks[0][i];
//      for (int j = 1; j < blockNum; j++)
//      {
//        if (blocks[j][i] == keta)
//        {
//          keta = '0';
//        }
//        else
//        {
//          keta = '1';
//        }
//      }
//      ans += keta;
//    }
//    Console.WriteLine(ans);
//  }
//}