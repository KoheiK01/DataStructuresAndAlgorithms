//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【全探索 4】ストラックアウト **********/
//    //【全探索 1】高い寿司を食いたい！
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = inputs[0], K = inputs[1];
//    //int[] prices = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  prices[i] = int.Parse(Console.ReadLine());
//    //}
//    //int max = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int price = 0;
//    //  for (int j = 0; j < K; j++)
//    //  {
//    //    price += prices[(i + j) % N];
//    //  }
//    //  max = Math.Max(max, price);
//    //}
//    //Console.WriteLine(max);

//    //【全探索 2】コップの水
//    //int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = inputs[0], X = inputs[1];
//    //int[] cups = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  cups[i] = int.Parse(Console.ReadLine());
//    //}
//    //bool[] dp = new bool[X + 1];
//    //dp[0] = true;
//    //int ans = 0;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  for (int j = X; j >= cups[i]; j--)
//    //  {
//    //    if (dp[j - cups[i]])
//    //    {
//    //      dp[j] = true;
//    //      ans = Math.Max(ans,j);
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(ans);

//    //【全探索 3】+1, -1, '1' +, +'1'
//    //int N = int.Parse(Console.ReadLine());
//    //int[] X = new int[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  X[i] = int.Parse(Console.ReadLine());
//    //}
//    //int lucky = int.MaxValue;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int[] nums1 = GenerateNums(X[i]);
//    //  for (int j = i + 1; j < N; j++)
//    //  {
//    //    int[] nums2 = GenerateNums(X[j]);
//    //    foreach (int x in nums1)
//    //    {
//    //      foreach (int y in nums2)
//    //      {
//    //        lucky = Math.Min(lucky, Math.Abs(x - y));
//    //      }
//    //    }
//    //  }
//    //}
//    //Console.WriteLine(lucky);

//    //【全探索 4】ストラックアウト
//  //  int[] panels = Enumerable.Range(0, 9).ToArray();
//  //  int[] s = new int[9];
//  //  for (int i = 0; i < 3; i++)
//  //  {
//  //    int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
//  //    for (int j = 0; j < 3; j++)
//  //    {
//  //      s[i * 3 + j] = temp[j];
//  //    }
//  //  }
//  //  int ans = s.Sum();
//  //  int[][] b = new int[9][];
//  //  for (int i = 0; i < 9; i++)
//  //  {
//  //    b[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
//  //  }
//  //  List<int[]> permute = new List<int[]>();
//  //  Permute(permute, panels.ToList(), 0);
//  //  int addMax = 0;
//  //  foreach (int[] tempPermute in permute)
//  //  {
//  //    bool[] opened = new bool[9];
//  //    int add = 0;
//  //    for (int i = 0; i < 9; i++)
//  //    {
//  //      int bingoCount = 0;
//  //      switch (tempPermute[i])
//  //      {
//  //        case 0:
//  //          if (opened[1] && opened[2])
//  //            bingoCount++;
//  //          if (opened[3] && opened[6])
//  //            bingoCount++;
//  //          if (opened[4] && opened[8])
//  //            bingoCount++;
//  //          break;

//  //        case 1:
//  //          if (opened[0] && opened[2])
//  //            bingoCount++;
//  //          if (opened[4] && opened[7])
//  //            bingoCount++;
//  //          break;

//  //        case 2:
//  //          if (opened[0] && opened[1])
//  //            bingoCount++;
//  //          if (opened[5] && opened[8])
//  //            bingoCount++;
//  //          if (opened[4] && opened[6])
//  //            bingoCount++;
//  //          break;

//  //        case 3:
//  //          if (opened[4] && opened[5])
//  //            bingoCount++;
//  //          if (opened[0] && opened[6])
//  //            bingoCount++;
//  //          break;

//  //        case 4:
//  //          if (opened[3] && opened[5])
//  //            bingoCount++;
//  //          if (opened[1] && opened[7])
//  //            bingoCount++;
//  //          if (opened[0] && opened[8])
//  //            bingoCount++;
//  //          if (opened[2] && opened[6])
//  //            bingoCount++;
//  //          break;

//  //        case 5:
//  //          if (opened[2] && opened[8])
//  //            bingoCount++;
//  //          if (opened[3] && opened[4])
//  //            bingoCount++;
//  //          break;

//  //        case 6:
//  //          if (opened[0] && opened[3])
//  //            bingoCount++;
//  //          if (opened[7] && opened[8])
//  //            bingoCount++;
//  //          if (opened[2] && opened[4])
//  //            bingoCount++;
//  //          break;

//  //        case 7:
//  //          if (opened[1] && opened[4])
//  //            bingoCount++;
//  //          if (opened[6] && opened[8])
//  //            bingoCount++;
//  //          break;

//  //        case 8:
//  //          if (opened[2] && opened[5])
//  //            bingoCount++;
//  //          if (opened[6] && opened[7])
//  //            bingoCount++;
//  //          if (opened[0] && opened[4])
//  //            bingoCount++;
//  //          break;
//  //      }
//  //      opened[tempPermute[i]] = true;
//  //      if (bingoCount > 0)
//  //      {
//  //        add += b[tempPermute[i]][bingoCount - 1];
//  //      }
//  //    }
//  //    addMax = Math.Max(addMax, add);
//  //  }
//  //  Console.WriteLine(addMax + ans);
//  //}

//  //【全探索 3】+1, -1, '1' +, +'1'
//  //private static int[] GenerateNums(int num)
//  //{
//  //  return new int[]
//  //  {
//  //    num,
//  //    num +1,
//  //    num - 1,
//  //    int.Parse("1" + num),
//  //    int.Parse(num + "1")
//  //  };
//  //}

//  //【全探索 4】ストラックアウト
//  //private static void Permute(List<int[]> permute, List<int> tempPermute, int start)
//  //{
//  //  for (int i = start; i < tempPermute.Count; i++)
//  //  {
//  //    Swap(tempPermute, i, start);
//  //    Permute(permute, tempPermute, start + 1);
//  //    Swap(tempPermute, start, i);
//  //  }

//  //  if (start == tempPermute.Count - 1)
//  //  {
//  //    permute.Add(tempPermute.ToArray());
//  //  }
//  //}
//  //private static void Swap(List<int> list, int i, int j)
//  //{
//  //  int temp = list[i];
//  //  list[i] = list[j];
//  //  list[j] = temp;
//  //}
//}