//using System;
//using System.ComponentModel.Design.Serialization;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    int i1 = 0;
//    int i2 = 0;

//    for (int i = 0; i < n; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      if (words[0] == "SET")
//      {
//        if (words[1] == "1")
//        {
//          i1 = int.Parse(words[2]);
//        }
//        else
//        {
//          i2 = int.Parse(words[2]);
//        }
//      }
//      else if (words[0] == "ADD")
//      {
//        i2 = i1 + int.Parse(words[1]);
//      }
//      else
//      {
//        i2 = i1 - int.Parse(words[1]);
//      }
//    }
//    Console.WriteLine(i1+" "+i2);
//  }
//}