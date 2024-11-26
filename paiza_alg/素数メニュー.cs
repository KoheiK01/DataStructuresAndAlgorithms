//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 素数大学 **********/
//    //STEP: 1 グロタンディーク素数
//    //STEP: 2 素数判定
//    //STEP: 3 大きな数の素数判定
//    //int N = 57;
//    //long N = long.Parse(Console.ReadLine());
//    //bool isPrime = IsPrime(N);
//    //Console.WriteLine(isPrime ? "YES" : "NO");

//    //STEP: 4 エラトステネスの篩
//    //int N = int.Parse(Console.ReadLine());
//    //bool[] isPrimes = Eratosthenes(N);
//    //Console.WriteLine(isPrimes[N] ? "YES" : "NO");

//    //STEP: 5 フェルマーテスト
//    //int N = int.Parse(Console.ReadLine());
//    //bool isPrime = FermatTest(N);
//    //Console.WriteLine(isPrime ? "YES" : "NO");

//    //FINAL問題 素数大学
//    //int max = 6000000;
//    //bool[] isPrimes = Eratosthenes(max);
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int n = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(isPrimes[n] ? "pass" : "failure");
//    //}

//    /********** 最小公倍数 **********/
//    //STEP: 1 素因数分解
//    //int N = int.Parse(Console.ReadLine());
//    //Dictionary<int, int> factors = Factorize(N);
//    //foreach (var item in factors)
//    //{
//    //  for (int i = 0; i < item.Value; i++)
//    //  {
//    //    Console.WriteLine(item.Key);
//    //  }
//    //}

//    //STEP: 2 約数の個数
//    //int N = int.Parse(Console.ReadLine());
//    //Dictionary<int, int> factors = Factorize(N);
//    //int ans = 1;
//    //foreach (var item in factors)
//    //{
//    //  ans *= item.Value + 1;
//    //}
//    //Console.WriteLine(ans);

//    //STEP: 3 最大公約数
//    //int N = int.Parse(Console.ReadLine());
//    //int a0 = int.Parse(Console.ReadLine());
//    //Dictionary<int, int> factors = Factorize(a0);
//    //for (int i = 1; i < N; i++)
//    //{
//    //  int ai = int.Parse(Console.ReadLine());
//    //  var temp = Factorize(ai);
//    //  foreach (var key in factors.Keys.ToList())
//    //  {
//    //    if (temp.ContainsKey(key)) { factors[key] = Math.Min(temp[key], factors[key]); }
//    //    else { factors[key] = 0; }
//    //  }
//    //}
//    //int ans = 1;
//    //foreach (var item in factors)
//    //{
//    //  ans *= (int)Math.Pow(item.Key, item.Value);
//    //}
//    //Console.WriteLine(ans);

//    //FINAL問題 最小公倍数
//    //int N = int.Parse(Console.ReadLine());
//    //Dictionary<int, int> factors = new Dictionary<int, int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int ai = int.Parse(Console.ReadLine());
//    //  var temp = Factorize(ai);
//    //  foreach (var item in temp)
//    //  {
//    //    if (!factors.ContainsKey(item.Key)) { factors.Add(item.Key, 0); }
//    //    factors[item.Key] = Math.Max(item.Value, factors[item.Key]);
//    //  }
//    //}
//    //long ans = 1;
//    //foreach (var item in factors)
//    //{
//    //  ans *= (long)Math.Pow(item.Key, item.Value);
//    //}
//    //Console.WriteLine(ans);

//    /********** paiza 予想 **********/
//    //STEP: 1 ゴールドバッハ予想
//    //int N = int.Parse(Console.ReadLine());
//    //bool[] isPrimes = Eratosthenes(N);
//    //long max = 0;
//    //int x = 0, y = 0;
//    //if (N == 4) { x = 2; y = 2; }
//    //for (int i = 3; i <= N / 2; i += 2)
//    //{
//    //  int other = N - i;
//    //  long pow = (long)i * other;
//    //  if (isPrimes[i] && isPrimes[N - i] && pow > max)
//    //  {
//    //    max = pow;
//    //    x = i;
//    //    y = other;
//    //  }
//    //}
//    //Console.WriteLine(x + "\n" + y);

//    //STEP: 2 中国剰余定理
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //long m1 = inputs[0], m2 = inputs[1], b1 = inputs[2], b2 = inputs[3];
//    //for (long m = 0; m < m2; m++)
//    //{
//    //  long z = m1 * m + b1;
//    //  if (z % m2 == b2)
//    //  {
//    //    Console.WriteLine(z);
//    //    break;
//    //  }
//    //}

//    //FINAL問題 paiza 予想
//    //bool[] isPrimes = Eratosthenes((int)Math.Pow(10, 8));
//    //bool allCorrect = true;
//    //for (int i = 3; i * i <= (int)Math.Pow(10, 8); i += 2)
//    //{
//    //  int n = i * i;
//    //  int n = (i + 2) * (i + 2);
//    //  bool correct = false;
//    //  for (int j = 2; j * j <= n; j++)
//    //  {
//    //    if (isPrimes[j] && isPrimes[n - j])
//    //    {
//    //      correct = true;
//    //      break;
//    //    }
//    //  }
//    //  if (!correct)
//    //  {
//    //    allCorrect = false;
//    //    Console.WriteLine(n);
//    //  }
//    //}
//    //if (allCorrect) { Console.WriteLine("paiza's conjecture is correct."); }
//  }

//  /********** 素数大学 **********/
//  //STEP: 1 グロタンディーク素数
//  private static bool IsPrime(long n)
//  {
//    if (n == 1)
//    {
//      return false;
//    }
//    for (long i = 2; i * i <= n; i++)
//    {
//      if (n % i == 0)
//      {
//        return false;
//      }
//    }
//    return true;
//  }

//  //STEP: 4 エラトステネスの篩
//  private static bool[] Eratosthenes(int n)
//  {
//    bool[] isPrimes = Enumerable.Repeat(true, n + 1).ToArray();
//    isPrimes[0] = isPrimes[1] = false;
//    for (int i = 2; i <= n; i++)
//    {
//      if (isPrimes[i])
//      {
//        for (long j = i * 2; j <= n; j += i)
//        {
//          isPrimes[j] = false;
//        }
//      }
//    }
//    return isPrimes;
//  }

//  //STEP: 5 フェルマーテスト
//  private static bool FermatTest(int n)
//  {
//    int a = 2;
//    if (n % a == 0)
//    {
//      return false;
//    }
//    int fermat = 1;
//    for (int i = 0; i < n - 1; i++)
//    {
//      fermat *= a;
//      fermat %= n;
//    }
//    return fermat == 1 ? true : false;
//  }

//  /********** 最小公倍数 **********/
//  //STEP: 1 素因数分解
//  private static Dictionary<int, int> Factorize(int n)
//  {
//    Dictionary<int, int> factors = new Dictionary<int, int>();
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