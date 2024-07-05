//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'strNum チャレンジ！！
//    string strN = Console.ReadLine();
//    bool yes = false;

//    while (!yes)
//    {
//      string revStrN = "";
//      for (int i = strN.Length - 1; i >= 0; i--)
//      {
//        revStrN += strN[i];
//      }
//      int n = int.Parse(strN);
//      int revN = int.Parse(revStrN);
//      strN = (n + revN).ToString();
//      int length = strN.Length;
//      for (int i = 0; i <= length / 2; i++)
//      {
//        if (strN[i] != strN[length - i - 1])
//        {
//          break;
//        }
//        if (i == strN.Length / 2)
//        {
//          yes = true;
//        }
//      }
//      if (yes)
//      {
//        break;
//      }
//    }

//    Console.WriteLine(strN);
//  }
//}