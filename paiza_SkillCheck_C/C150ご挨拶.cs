//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int houseNum = int.Parse(words[0]);
//    int distanceMax = int.Parse(words[1]);
//    words = Console.ReadLine().Split(' ');
//    int nowx = int.Parse(words[0]);
//    int nowy = int.Parse(words[1]);
//    int ans = 0;
//    for (int i = 0; i < houseNum; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      int xi = int.Parse(words[0]);
//      int yi = int.Parse(words[1]);

//      int distance = Math.Abs(nowx - xi) + Math.Abs(nowy - yi);
//      if (distance <= distanceMax)
//      {
//        ans++;
//      }
//    }
//    Console.WriteLine(ans); 
//  }
//}