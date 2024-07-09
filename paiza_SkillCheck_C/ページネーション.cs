//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int s = int.Parse(words[1]);
//    int p = int.Parse(words[2]);

//    int pageMax = (int)Math.Ceiling((double)n / s);
//    if (pageMax < p)
//    {
//      Console.WriteLine("none");
//      return;
//    }

//    int lastPageNum = n % s;
//    int[][] pages = new int[pageMax][];
//    for (int page = 0; page < pageMax; page++)
//    {
//      pages[page] = new int[s];
//    }
//    if(lastPageNum!=0)
//    {
//      pages[pageMax - 1] = new int[lastPageNum];
//    }

//    for (int page = 0; page < pageMax; page++)
//    {
//      for (int content = 1; content <= pages[page].Length; content++)
//      {
//        pages[page][content - 1] = page * s + content;
//      }
//    }
//    Console.WriteLine(string.Join(" ", pages[p - 1]));
//  }
//}
