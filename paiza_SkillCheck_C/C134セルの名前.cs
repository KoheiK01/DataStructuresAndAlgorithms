//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！！
//    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    int n = int.Parse(Console.ReadLine());

//    string ans = "";
//    while (n > 0)
//    {
//      n--;
//      int index = n % alphabet.Length;
//      ans = alphabet[index] + ans;
//      n /= 26;
//    }
//    Console.WriteLine(ans);
//  }
//}