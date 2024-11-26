//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 拡張ユークリッドの互除法 **********/
//    //STEP: 1 ユークリッドの互除法
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = inputs[0], B = inputs[1];
//    //Console.WriteLine(A,B));

//    //STEP: 2 3 つ以上の整数の最大公約数
//    //int N = int.Parse(Console.ReadLine());
//    //int gcd = int.Parse(Console.ReadLine());
//    //for (int i = 1; i < N; i++)
//    //{
//    //  int ai = int.Parse(Console.ReadLine());
//    //  gcd = Gcd(gcd, ai);
//    //}
//    //Console.WriteLine(gcd);

//    //STEP: 3 最小公倍数
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = inputs[0], B = inputs[1];
//    //Console.WriteLine(Lcm(A, B));

//    //STEP: 4 ax + by = c
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = inputs[0], B = inputs[1], C = inputs[2];
//    //int x, y;
//    //if (A % B == C) { x = 1; y = -1 * A / B; }
//    //else { x = -1 * B / A; y = 1; }
//    //int[] cxy = EctGcd(A, B);
//    //Console.WriteLine($"{x} {y}");

//    //FINAL問題 拡張ユークリッドの互除法
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = inputs[0], B = inputs[1];
//    //int[] cxy = EctGcd(A, B);
//    //Console.WriteLine($"{cxy[1]} {cxy[2]}");
//  }

//  private static int Gcd(int a, int b)
//  {
//    while (b != 0)
//    {
//      int surplus = a % b;
//      a = b;
//      b = surplus;
//    }
//    return a;
//  }

//  private static int Lcm(int a, int b)
//  {
//    int gcd = Gcd(a, b);
//    return a / gcd * b;
//  }

//  private static int[] EctGcd(int a, int b)
//  {
//    if (b != 0)
//    {
//      int[] cyx = EctGcd(b, a % b);
//      int c = cyx[0], y = cyx[1], x = cyx[2];
//      y -= a / b * x;
//      return new int[] { c, x, y };
//    }
//    return new int[] { a, 1, 0 };
//  }
//}