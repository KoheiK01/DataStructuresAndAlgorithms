//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int h = int.Parse(words[0]);
//    int w = int.Parse(words[1]);

//    for (int i = 0; i < h; i++)
//    {
//      int[] ans = new int[w];

//      words = Console.ReadLine().Split(' ');
//      for (int j = 0; j < w; j++)
//      {
//        int p = int.Parse(words[j]);
//        if (p >= 128)
//        {
//          ans[j] = 1;
//        }
//        else
//        {
//          ans[j] = 0;
//        }
//      }
//      Console.WriteLine(string.Join(" ", ans));
//    }
//  }
//}