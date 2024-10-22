//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');

//    int train = int.Parse(words[0]);
//    int hotel = int.Parse(words[1]);
//    int n = int.Parse(words[2]);
//    int[] starts = new int[n];
//    int[] ends = new int[n];
//    for (int i = 0; i < n; i++)
//    {
//      words = Console.ReadLine().Split(' ');
//      starts[i] = int.Parse(words[0]);
//      ends[i] = int.Parse(words[1]);
//    }

//    int money = train;
//    for (int i = 1; i < n; i++)
//    {
//      money += Math.Min(2 * train, (starts[i] - ends[i - 1]) * hotel);
//    }
//    money += train;
//    Console.WriteLine(money);
//  }
//}