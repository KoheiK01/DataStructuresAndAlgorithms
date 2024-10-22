//using System;
//using System.CodeDom;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int h = int.Parse(words[0]);
//    int w = int.Parse(words[1]);

//    bool[,] maps = new bool[h, w];
//    for (int i = 0; i < h; i++)
//    {
//      var s = Console.ReadLine();
//      for (int j = 0; j < w; j++)
//      {
//        if (s[j] == 'o')
//        {
//          maps[i, j] = true;
//        }
//      }
//    }

//    int ans = 0;
//    for (int i = 0; i < h; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      for (int j = 0; j < w; j++)
//      {
//        if (maps[i, j])
//        {
//          ans += int.Parse(words[j]);
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}