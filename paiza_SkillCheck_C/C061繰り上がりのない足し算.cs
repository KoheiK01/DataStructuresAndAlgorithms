//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    string tempa = words[0];
//    string tempb = words[1];
//    int maxl = Math.Max(tempa.Length, tempb.Length);

//    string[] a = new string[maxl];
//    string[] b = new string[maxl];

//    for (int i = 0; i < maxl; i++)
//    {
//      if (tempa.Length > i)
//      {
//        a[maxl - 1 - i] = tempa[tempa.Length - 1 - i].ToString();
//      }
//      else
//      {
//        a[maxl - 1 - i] = "0";
//      }
//      if (tempb.Length > i)
//      {
//        b[maxl - 1 - i] = tempb[tempb.Length - 1 - i].ToString();
//      }
//      else
//      {
//        b[maxl - 1 - i] = "0";
//      }
//    }

//    string ans = "";
//    for (int i = 0; i < maxl; i++)
//    {
//      ans += ((int.Parse(a[i]) + int.Parse(b[i])) % 10).ToString();
//    }
//    Console.WriteLine(ans);
//  }
//}
