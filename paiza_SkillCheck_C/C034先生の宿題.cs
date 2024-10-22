//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    string op = words[1];
//    int ans;
//    int a, b, c;

//    if (words[0] == "x")
//    {
//      b = int.Parse(words[2]);
//      c = int.Parse(words[4]);
//      if (op == "+")
//      {
//        ans = -b + c;
//      }
//      else
//      {
//        ans = b + c;
//      }
//    }
//    else if (words[2] == "x")
//    {
//      a = int.Parse(words[0]);
//      c = int.Parse(words[4]);
//      if (op == "+")
//      {
//        ans = -a + c;
//      }
//      else
//      {
//        ans = a - c;
//      }
//    }
//    else
//    {
//      a = int.Parse(words[0]);
//      b = int.Parse(words[2]);
//      if (op == "+")
//      {
//        ans = a + b;
//      }
//      else
//      {
//        ans = a - b;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}