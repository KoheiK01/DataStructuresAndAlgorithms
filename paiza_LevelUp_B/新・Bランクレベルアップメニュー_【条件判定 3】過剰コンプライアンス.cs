//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【条件判定 3】過剰コンプライアンス **********/
//    //【条件判定 1】郵便料金
//    //int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int y = sizes[0], x = sizes[1], h = sizes[2];
//    //int[] ls = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] ms = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int ans = 0;
//    //if (h <= ls[0])
//    //{
//    //  if (Math.Max(y, x) <= ls[1]) { ans = ms[0]; }
//    //  else if (y + x <= ls[2]) { ans = ms[1]; }
//    //  else { ans = ms[2]; }
//    //}
//    //else
//    //{
//    //  if (sizes.Max() <= ls[3]) { ans = ms[3]; }
//    //  else if (sizes.Sum() <= ls[4]) { ans = ms[4]; }
//    //  else { ans = y * x * h * ms[5]; }
//    //}
//    //Console.WriteLine(ans);


//    //【条件判定 2】視力検査
//    //string[] tests = { "TA", "TB", "TC", "TD" };
//    //string[] ranks = { "A", "B", "C", "D", "E" };
//    //int[] okCounts = new int[4];
//    //int[] ngCounts = new int[4];
//    //int nowRank = 4;
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  int rank = Array.IndexOf(tests, _strings[0]);
//    //  if (nowRank <= rank) { continue; }
//    //  if (_strings[1] == "ok")
//    //  {
//    //    okCounts[rank]++;
//    //    if (okCounts[rank] == 2 && ngCounts[rank] < 2)
//    //    {
//    //      nowRank = rank;
//    //    }
//    //  }
//    //  else
//    //  {
//    //    ngCounts[rank]++;
//    //  }
//    //}
//    //Console.WriteLine(ranks[nowRank]);

//    //【条件判定 3】過剰コンプライアンス
//    //int N = int.Parse(Console.ReadLine());
//    //string S = Console.ReadLine();
//    //int harfLen = (int)Math.Ceiling((double)S.Length / 2);
//    //int harfIndex = S.Length / 2;
//    //string UpperS = S.Substring(0, harfLen);
//    //string LowerS = S.Substring(harfIndex, harfLen);
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string V = Console.ReadLine();
//    //  if (V.Length == S.Length)
//    //  {
//    //    if (S == V)
//    //    {
//    //      Console.WriteLine("banned");
//    //    }
//    //    else
//    //    {
//    //      if (V.Substring(0, harfLen) == UpperS)
//    //      {
//    //        Console.WriteLine(new string('x', harfLen) + V.Substring(harfLen));
//    //      }
//    //      else if (V.Substring(harfIndex, harfLen) == LowerS)
//    //      {
//    //        Console.WriteLine(V.Substring(0, harfIndex) + new string('x', harfLen));
//    //      }
//    //      else
//    //      {
//    //        Console.WriteLine(V);
//    //      }
//    //    }
//    //  }
//    //  else
//    //  {
//    //    Console.WriteLine(V);
//    //  }
//    //}
//  }
//}