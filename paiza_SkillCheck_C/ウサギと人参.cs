//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int N = int.Parse(words[0]);
//    int S = int.Parse(words[1]);
//    int p = int.Parse(words[2]);

//    string ans = "not found";
//    int maxm = 0;
//    for (int i = 1; i <= N; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int m = int.Parse(words[0]);
//      int s = int.Parse(words[1]);

//      if (S - p <= s & s <= S + p)
//      {
//        if (maxm < m)
//        {
//          maxm = m;
//          ans = i.ToString();
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}