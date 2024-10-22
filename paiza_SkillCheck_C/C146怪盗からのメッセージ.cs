//using System;
//using System.IO.Pipes;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string s = Console.ReadLine();
//    string alphaIndex = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    string alphaNext = "BCDEFGHIJKLMNOPQRSTUVWXYZA";

//    string strNum = "";
//    string ans = "";
//    for (int i = 0; i < s.Length; i++)
//    {
//      bool isNum = int.TryParse(s[i].ToString(), out int temp);
//      if (isNum)
//      {
//        strNum += temp;
//      }
//      else
//      {
//        if (strNum.Length >= 1)
//        {
//          ans += int.Parse(strNum.ToString()) + 1;
//          strNum = "";
//        }
//        int index = alphaIndex.IndexOf(s[i]);
//        ans += alphaNext[index];
//      }
//    }
//    if (strNum.Length >= 1)
//    {
//      ans += int.Parse(strNum.ToString()) + 1;
//    }

//    Console.WriteLine(ans);
//  }
//}
