//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    string rule = Console.ReadLine();
//    string input = Console.ReadLine();

//    var ans = "";
//    for (int i = 0; i < input.Length; i++)
//    {
//      if (rule.Contains(input[i].ToString()))
//      {
//        ans += input[i];
//      }
//      else if (rule.Contains(input[i].ToString().ToLower()))
//      {
//        ans += input[i].ToString().ToLower();
//      }
//      else if (rule.Contains(input[i].ToString().ToUpper()))
//      {
//        ans += input[i].ToString().ToUpper();
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}