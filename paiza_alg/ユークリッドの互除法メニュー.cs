//using System;
//using System.Collections.Generic;
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
//    //for (int B = 1; B < N; B++)
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

//    /********** 意地悪すごろく **********/
//    //STEP: 1 分数
//    //string[] inputs = Console.ReadLine().Split();
//    //int A = int.Parse(inputs[0]), B = int.Parse(inputs[1]);
//    //string cal = inputs[2];
//    //int C = int.Parse(inputs[3]), D = int.Parse(inputs[4]);
//    //int parent, child;
//    //int gcd;
//    //switch (cal)
//    //{
//    //  case "+":
//    //    parent = Lcm(B, D);
//    //    child = parent / B * A + parent / D * C;
//    //    break;

//    //  case "-":
//    //    parent = Lcm(B, D);
//    //    child = parent / B * A - parent / D * C;
//    //    break;

//    //  case "*":
//    //    gcd = Gcd(B, C);
//    //    B /= gcd; C /= gcd;
//    //    gcd = Gcd(A, D);
//    //    A /= gcd; D /= gcd;
//    //    parent = B * D;
//    //    child = A * C;
//    //    break;

//    //  default:
//    //    gcd = Gcd(B, D);
//    //    B /= gcd; D /= gcd;
//    //    gcd = Gcd(A, C);
//    //    A /= gcd; C /= gcd;
//    //    parent = B * C;
//    //    child = A * D;
//    //    break;
//    //}
//    //gcd = Gcd(parent, child);
//    //parent /= gcd; child /= gcd;
//    //if (parent < 0)
//    //{
//    //  parent *= -1;
//    //  child *= -1;
//    //}
//    //Console.WriteLine($"{child} {parent}");

//    //FINAL問題 意地悪すごろく
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = inputs[0], A = inputs[1];
//    //bool canGole = true;
//    //for (int B = 2; B <= 1000; B++)
//    //{
//    //  if (A == B) continue;
//    //  int gcd = Gcd(A, B);
//    //  if (N % gcd != 0)
//    //  {
//    //    Console.WriteLine(B);
//    //    canGole = false;
//    //  }
//    //}
//    //if (canGole) { Console.WriteLine(-1); }

//    /********** RSA 暗号の基本原理 **********/
//    //STEP: 1 合同式
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = inputs[0], A = inputs[1];
//    //int r = A % N;
//    //for (int B = 1; B <= 100000; B++)
//    //{
//    //  if (B % N == r)
//    //  {
//    //    Console.WriteLine(B);
//    //  }
//    //}

//    //STEP: 2 mod の演算
//    //int N = int.Parse(Console.ReadLine());
//    //string[] inputs = Console.ReadLine().Split();
//    //int A = int.Parse(inputs[0]), B = int.Parse(inputs[2]);
//    //string cal = inputs[1];
//    //switch (cal)
//    //{
//    //  case "+":
//    //    Console.WriteLine(((A % N) + (B % N)) % N);
//    //    break;
//    //  case "-":
//    //    Console.WriteLine(((A % N) - (B % N) + N) % N);
//    //    break;
//    //  case "*":
//    //    Console.WriteLine(A % N * B % N % N);
//    //    break;
//    //  case "^":
//    //    int ans = 1;
//    //    for (int i = 0; i < B; i++)
//    //    {
//    //      ans *= A;
//    //      ans %= N;
//    //    }
//    //    Console.WriteLine(ans);
//    //    break;
//    //}

//    //STEP: 3 mod の逆元
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int M = inputs[0], A = inputs[1];
//    //int[] cxy = EctGcd(A, M);
//    //if (cxy[1] < 0)
//    //{
//    //  cxy[1] = (cxy[1] + M) % M; ;
//    //}
//    //Console.WriteLine(cxy[1]);

//    //STEP: 4 高速な累乗の計算
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int A = inputs[0], B = inputs[1], M = inputs[2];
//    //Console.WriteLine(ModPow(A, B, M));

//    //FINAL問題 RSA 暗号の基本原理
//    //long[] inputs = Console.ReadLine().Split().Select(long.Parse).ToArray();
//    //long p = inputs[0], q = inputs[1], e = inputs[2], M = inputs[3];
//    //long n = p * q;
//    //long nPrime = (p - 1) * (q - 1);
//    //long[] gcdxy = EctGcd(e, nPrime);
//    //long d = (gcdxy[1] + nPrime) % nPrime;
//    //long E = ModPow((ulong)M, (ulong)e, (ulong)n);
//    //Console.WriteLine(d);
//    //Console.WriteLine(E);
//    //Console.WriteLine(ModPow((ulong)E, (ulong)d, (ulong)n));

//    /********** RSA 暗号の作成（文字列） **********/
//    //STEP: 1 RSA 暗号の解読（1文字）
//    //STEP: 2 RSA 暗号の解読（文字列）
//    //long[] inputs = Console.ReadLine().Split().Select(long.Parse).ToArray();
//    //long n = inputs[0], e = inputs[1], E = inputs[2];
//    //long p = inputs[0], q = inputs[1], e = inputs[2], E = inputs[3];
//    //long n = p * q;
//    //var pq = Factorize(n);
//    //var keys = pq.Keys.ToList();
//    //long p = keys[0], q = keys[1];
//    //long nPrime = (p - 1) * (q - 1);
//    //long[] gcdxy = EctGcd(e, nPrime);
//    //long d = (gcdxy[1] + nPrime) % nPrime;
//    //ulong letter = ModPow((ulong)E, (ulong)d, (ulong)n);
//    //List<byte> bytes = SplitToBytes(letter);
//    //foreach (var item in bytes)
//    //{
//    //  if (item != 0) { Console.Write((char)item); }
//    //}
//    //Console.WriteLine((char)letter);

//    //FINAL問題 RSA 暗号の作成（文字列）
//    //long n = 3995747143, e = 3007;
//    //var pq = Factorize(n);
//    //var keys = pq.Keys.ToList();
//    //long p = keys[0], q = keys[1];
//    //long nPrime = (p - 1) * (q - 1);
//    //long[] gcdxy = EctGcd(e, nPrime);
//    //long d = (gcdxy[1] + nPrime) % nPrime;
//    //string fromS = "PAIZ";
//    //ulong M = ConvertTo28Bit(fromS);
//    //ulong E = ModPow(M, (ulong)e, (ulong)n);
//    //ulong letter = ModPow(E, (ulong)d, (ulong)n);
//    //List<byte> bytes = SplitToBytes(letter);
//    //Console.WriteLine($"{n} {e} {E}");
//    //foreach (var item in bytes)
//    //{
//    //  if (item != 0) { Console.Write((char)item); }
//    //}
//  }

//  private static List<byte> SplitToBytes(ulong letter)
//  {
//    List<byte> bytes = new List<byte>();

//    while (letter > 0)
//    {
//      bytes.Add((byte)(letter & 0x7F));
//      letter >>= 7;
//    }
//    bytes.Reverse();
//    return bytes;
//  }

//  private static ulong ConvertTo28Bit(string input)
//  {
//    ulong result = 0;

//    foreach (char c in input)
//    {
//      result = (result << 7) | c;
//    }
//    return result;
//  }


//  private static ulong ModPow(ulong a, ulong b, ulong m)
//  {
//    ulong ans = 1;
//    while (b != 0)
//    {
//      if ((b & 1) == 1)
//      {
//        ans = ans * a % m;
//      }
//      a = a * a % m;
//      b >>= 1;
//    }
//    return ans;
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

//  private static long[] EctGcd(long a, long b)
//  {
//    if (b != 0)
//    {
//      long[] cyx = EctGcd(b, a % b);
//      long c = cyx[0], y = cyx[1], x = cyx[2];
//      y -= a / b * x;
//      return new long[] { c, x, y };
//    }
//    return new long[] { a, 1, 0 };
//  }

//  private static Dictionary<long, long> Factorize(long n)
//  {
//    Dictionary<long, long> factors = new Dictionary<long, long>();
//    while (n % 2 == 0)
//    {
//      if (!factors.ContainsKey(2)) { factors[2] = 0; }
//      factors[2]++;
//      n /= 2;
//    }
//    for (int i = 3; i * i <= n; i += 2)
//    {
//      while (n % i == 0)
//      {
//        if (!factors.ContainsKey(i)) { factors[i] = 0; }
//        factors[i]++;
//        n /= i;
//      }
//    }
//    if (n > 1) { factors.Add(n, 1); }
//    return factors;
//  }
//}