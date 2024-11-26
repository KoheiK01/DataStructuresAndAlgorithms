//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 【指定された値の探索】指定された値の位置 3 **********/
//    //STEP: 1 指定された値の個数
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //Console.WriteLine(A.Count(a => a == k));

//    //STEP: 2 指定された値の位置 1
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //int index = A.ToList().IndexOf(k);
//    //Console.WriteLine(index == -1 ? 0 : index + 1);

//    //STEP: 3 指定された値の位置 2
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //int index = -1;
//    //for (int i = n - 1; i >= 0; i--)
//    //{
//    //  if (A[i] == k) { index = i; break; }
//    //}
//    //Console.WriteLine(index == -1 ? 0 : index + 1);

//    //FINAL問題 【指定された値の探索】指定された値の位置 3
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //int index = -1;
//    //for (int i = 0; i < n;i++)
//    //{
//    //  if (A[i] == k) { Console.WriteLine(i + 1); }
//    //}

//    /********** 【最大最小】n 変数の最大最小 **********/
//    //    //STEP: 1 2変数の最大最小
//    //    //STEP: 2 10変数の最大最小
//    //    //FINAL問題 【最大最小】n 変数の最大最小
//    //    //int n = int.Parse(Console.ReadLine());
//    //    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //    //Console.WriteLine($"{A.Max()} {A.Min()}");

//    /********** 【特殊な探索】 成績優秀者の列挙 2 **********/
//    //STEP: 1 偶数の探索
//    //STEP: 2 奇数の探索
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Console.WriteLine(A.ToList().FindLastIndex(a => a % 2 == 1) + 1);
//    //Console.WriteLine(A.ToList().FindIndex(a => a % 2 == 0) + 1);

//    //STEP: 3 条件付き最小値
//    //STEP: 4 条件付き最大値
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //Console.WriteLine(A.ToList().FindAll(a => a <= k).Max());
//    //Console.WriteLine(A.ToList().FindAll(a => a >= k).Min());

//    //STEP: 5 点と点の距離
//    //int n = int.Parse(Console.ReadLine());
//    //int[,] points = new int[n, 2];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int[] point = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < 2; j++)
//    //  {
//    //    points[i, j] = point[j];
//    //  }
//    //}
//    //int k = int.Parse(Console.ReadLine());
//    //int ans = 0;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  if (Math.Abs(points[i, 0] - points[n - 1, 0]) + Math.Abs(points[i, 1] - points[n - 1, 1]) <= k)
//    //  {
//    //    ans++;
//    //  }
//    //}
//    //Console.WriteLine(ans);

//    //STEP: 6 長方形に含まれる点
//    //int n = int.Parse(Console.ReadLine());
//    //int[,] points = new int[n, 2];
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int[] point = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  for (int j = 0; j < 2; j++)
//    //  {
//    //    points[i, j] = point[j];
//    //  }
//    //}
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int xs = input[0], xt = input[1];
//    //input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int ys = input[0], yt = input[1];
//    //int ans = 0;
//    //for (int i = 0; i < n; i++)
//    //{
//    //  if (points[i,0]>=xs && points[i,0]<=xt && points[i,1]>= ys&& points[i,1] <= yt)
//    //  {
//    //    ans++;
//    //  }
//    //}
//    //Console.WriteLine(ans);

//    //STEP: 7 成績優秀者の列挙 1
//    //int n = int.Parse(Console.ReadLine());
//    //Dictionary<string, int> scores = new Dictionary<string, int>();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split(' ');
//    //  scores.Add(line[0], int.Parse(line[1]));
//    //}
//    //int k = int.Parse(Console.ReadLine());
//    //foreach (var item in scores)
//    //{
//    //  if (item.Value >= k)
//    //  {
//    //    Console.WriteLine(item.Key);
//    //  }
//    //}

//    //FINAL問題 【特殊な探索】 成績優秀者の列挙 2
//    //int n = int.Parse(Console.ReadLine());
//    //Dictionary<string, int> scores = new Dictionary<string, int>();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  string[] line = Console.ReadLine().Split(' ');
//    //  scores.Add(line[0], int.Parse(line[1]));
//    //}
//    //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int k = input[0], l = input[1];
//    //foreach (var item in scores)
//    //{
//    //  if (item.Value >= k && item.Value <= l)
//    //  {
//    //    Console.WriteLine(item.Key);
//    //  }
//    //}

//    /********** 【第 k 要素の探索】k番目に大きな値 **********/
//    //STEP: 1 2番目に大きな値
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //A = A.OrderByDescending(x => x).ToArray();
//    //Console.WriteLine(A[1]);

//    //FINAL問題 【第 k 要素の探索】k番目に大きな値
//    //int n = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int k = int.Parse(Console.ReadLine());
//    //A = A.OrderByDescending(x => x).ToArray();
//    //Console.WriteLine(A[k - 1]);
//  }
//}