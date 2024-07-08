//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//    int n = int.Parse(Console.ReadLine());
//    string s = Console.ReadLine();

//    for (int i = 1; i <= s.Length; i++)
//    {
//      int index = alphabet.IndexOf(s[i - 1].ToString());
//      if (i % 2 == 1)
//      {
//        if (index - n >= 0)
//        {
//          index -= n;
//        }
//        else
//        {
//          index = alphabet.Length - (n - index);
//        }
//      }
//      else
//      {
//        if (index + n < alphabet.Length)
//        {
//          index += n;
//        }
//        else
//        {
//          index = n - (alphabet.Length - index);
//        }
//      }
//      Console.Write(alphabet[index]);
//    }
//  }
//}