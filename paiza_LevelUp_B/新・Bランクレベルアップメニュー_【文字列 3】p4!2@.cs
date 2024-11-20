//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【文字列 3】p4!2@ **********/
//    //【文字列 1】疑似数字
//    //string S = Console.ReadLine();
//    //for (int i = 0; i < S.Length; i++)
//    //{
//    //  if (!int.TryParse(S[i].ToString(), out _)) continue;
//    //  int j = 0;
//    //  while (i + j < S.Length)
//    //  {
//    //    if (int.TryParse(S[i + j].ToString(), out _))
//    //    {
//    //      Console.WriteLine(S.Substring(i, j + 1));
//    //    }
//    //    j++;
//    //  }
//    //}

//    //【文字列 2】super long int
//    //string X = Console.ReadLine();
//    //int hash = 0;
//    //for (int i = 0; i < 4; i++)
//    //{
//    //  hash += int.Parse(X.Substring(i * 8, 8));
//    //}
//    //Console.WriteLine(hash);

//    //【文字列 3】p4!2@
//  //  string S = Console.ReadLine();
//  //  string[] okLeet = new string[5];
//  //  okLeet[0] = "p";
//  //  okLeet[1] = "a4@";
//  //  okLeet[2] = "i1!";
//  //  okLeet[3] = "z2";
//  //  okLeet[4] = "a4@";
//  //  if (S.Contains("paiza"))
//  //  {
//  //    Console.WriteLine("paiza");
//  //    return;
//  //  }
//  //  else
//  //  {
//  //    for (int i = 0; i <= S.Length - 5; i++)
//  //    {
//  //      for (int j = 0; j < 5; j++)
//  //      {
//  //        if (!okLeet[j].Contains(S[i + j]))
//  //        {
//  //          break;
//  //        }
//  //        if (j == 4)
//  //        {
//  //          Console.WriteLine("leet");
//  //          return;
//  //        }
//  //      }
//  //    }
//  //  }
//  //  Console.WriteLine("nothing");
//  //}
//}