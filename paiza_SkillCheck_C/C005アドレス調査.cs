//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int M = int.Parse(Console.ReadLine());

//    for (int i = 0; i < M; i++)
//    {
//      string s = Console.ReadLine();
//      if (IsValidIPv4(s))
//      {
//        Console.WriteLine("True");
//      }
//      else
//      {
//        Console.WriteLine("False");
//      }
//    }
//  }

//  static bool IsValidIPv4(string ip)
//  {
//    if (ip.Count(c => c == '.') != 3)
//    {
//      return false;
//    }

//    var words = ip.Split('.');
//    if (words.Length != 4)
//    {
//      return false;
//    }

//    foreach (var word in words)
//    {
//      if (!int.TryParse(word, out int number))
//      {
//        return false;
//      }
//      if (number < 0 || number > 255)
//      {
//        return false;
//      }
//    }
//    return true;
//  }
//}
