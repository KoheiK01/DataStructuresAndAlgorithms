//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');
//    int D = int.Parse(words[0]);
//    int N = int.Parse(words[1]);
//    int L = int.Parse(words[2]);

//    string ans = "Yes";
//    int now = 0;
//    int sum = 0;
//    for (int i = 0; i < N; i++)
//    {
//      int k = int.Parse(Console.ReadLine());
//      int rightD = k - now;
//      int leftD = now - k;

//      if (rightD < 0)
//      {
//        rightD = D + rightD;
//      }
//      else if (leftD < 0)
//      {
//        leftD = D + leftD;
//      }
//      sum += Math.Min(rightD, leftD);
//      now = k;
//      if (sum >= L)
//      {
//        ans = "No";
//        break;
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}