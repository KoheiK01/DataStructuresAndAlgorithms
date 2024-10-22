//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    int M = int.Parse(Console.ReadLine());
//    int N = int.Parse(Console.ReadLine());

//    int[] faxNums = new int[24];
//    for (int i = 0; i < N; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int x = int.Parse(words[0]);
//      int c = int.Parse(words[2]);
//      faxNums[x] += c;
//    }

//    int ans = 0;
//    for (int i = 0; i < 24; i++)
//    {
//      int num = (int)Math.Ceiling((double)faxNums[i] / M);
//      ans += num;
//    }
//    Console.WriteLine(ans);
//  }
//}