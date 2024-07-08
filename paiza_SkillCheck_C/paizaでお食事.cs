//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int m = int.Parse(words[0]);
//    int n = int.Parse(words[1]);

//    int[] cals = new int[m];
//    for (int i = 0; i < m; i++)
//    {
//      cals[i] = int.Parse(Console.ReadLine());
//    }

//    for (int i = 0; i < n; i++)
//    {
//      int cal = 0;
//      words = Console.ReadLine().Split(' ');
//      for (int j = 0; j < m; j++)
//      {
//        int a = int.Parse(words[j]);
//        cal += cals[j] * a / 100;
//      }
//      Console.WriteLine(cal);
//    }
//  }
//}