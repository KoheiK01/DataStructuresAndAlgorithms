//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    bool paper = false;
//    bool rock = false;
//    bool scissors = false;
//    for (int i = 0; i < n; i++)
//    {
//      string a = Console.ReadLine();
//      if (a == "paper")
//      {
//        paper = true;
//      }
//      else if (a == "rock")
//      {
//        rock = true;
//      }
//      else
//      {
//        scissors = true;
//      }
//    }

//    int kind = 0;
//    if (paper) { kind++; }
//    if (rock) { kind++; }
//    if (scissors) { kind++; }

//    string ans;
//    if (kind == 3 || kind == 1)
//    {
//      ans = "draw";
//    }
//    else if (paper && rock)
//    {
//      ans = "paper";
//    }
//    else if (rock && scissors)
//    {
//      ans = "rock";
//    }
//    else
//    {
//      ans = "scissors";
//    }

//    Console.WriteLine(ans);
//  }
//}