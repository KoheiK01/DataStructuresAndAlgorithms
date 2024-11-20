//using System;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【シミュレーション 4】位置情報システム **********/
//    //【シミュレーション 1】反復横跳び
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = firstLine[0], X = firstLine[1], K = firstLine[2];
//    //if (K % 4 == 3)
//    //{
//    //  Console.WriteLine((long)2 * X * ((K - 4 * N) / 4) + X);
//    //}
//    //else
//    //{
//    //  Console.WriteLine((long)2 * X * ((K - 4 * N) / 4));
//    //}

//    //【シミュレーション 2】perfect shuffle
//    //int cardNum = 4 * 13;
//    //int harfCardNum = cardNum / 2;
//    //string[] cards = new string[cardNum];
//    //string[] mark = { "S_", "H_", "D_", "C_" };
//    //for (int i = 0; i < 4; i++)
//    //{
//    //  for (int j = 1; j <= 13; j++)
//    //  {
//    //    cards[i * 13 + j - 1] = mark[i] + j;
//    //  }
//    //}
//    //int K = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] upper = cards.Take(harfCardNum).ToArray();
//    //  string[] lower = cards.Skip(harfCardNum).ToArray();
//    //  for (int j = harfCardNum - 1; j >= 0; j -= 1)
//    //  {
//    //    cards[j * 2 + 1] = lower[j];
//    //    cards[j * 2] = upper[j];
//    //  }
//    //}
//    //Console.WriteLine(string.Join("\n", cards));

//    //【シミュレーション 3】燃費
//    //int X = int.Parse(Console.ReadLine());
//    //int[] fuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int f1 = fuel[0], f2 = fuel[1];
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int L = input[0], N = input[1];
//    //long[] s = Console.ReadLine().Split().Select(long.Parse).Prepend(0).Append(L).ToArray();
//    //long ans = 0;
//    //for (int i = 1; i < s.Length; i++)
//    //{
//    //  long distance = s[i] - s[i - 1];
//    //  ans += distance > X ? X * f1 + (distance - X) * f2 : distance * f1;
//    //}
//    //Console.WriteLine(ans);

//    //【シミュレーション 4】位置情報システム
//    //int n = int.Parse(Console.ReadLine());
//    //int[] times = new int[n];
//    //long[] y = new long[n];
//    //long[] x = new long[n];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] input = Console.ReadLine().Split();
//    //  times[i] = int.Parse(input[0]);
//    //  y[i] = long.Parse(input[1]);
//    //  x[i] = long.Parse(input[2]);
//    //}
//    //int index = 0;
//    //for (int time = 0; time <= 100; time++)
//    //{
//    //  if (time == times[index])
//    //  {
//    //    Console.WriteLine(y[index] + " " + x[index]);
//    //    index++;
//    //  }
//    //  else
//    //  {
//    //    long yt = (y[index] - y[index - 1]) * (time - times[index - 1]) / (times[index] - times[index - 1]) + y[index - 1];
//    //    long xt = (x[index] - x[index - 1]) * (time - times[index - 1]) / (times[index] - times[index - 1]) + x[index - 1];
//    //    Console.WriteLine(yt + " " + xt);
//    //  }
//    //}
//  }
//}
