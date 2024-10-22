//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int N = int.Parse(Console.ReadLine());

//    Dictionary<int, int> useNums = new Dictionary<int, int>();
//    var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    for (int i = 0; i < N; i++)
//    {
//      if (useNums.ContainsKey(a[i]))
//      {
//        useNums[a[i]]++;
//      }
//      else
//      {
//        useNums[a[i]] = 1;
//      }
//    }

//    useNums = useNums
//      .OrderByDescending(x => x.Value)
//      .ToDictionary(x => x.Key, x => x.Value);

//    int maxValue = useNums.First().Value;
//    List<int> list = useNums
//      .Where(x => x.Value == maxValue)
//      .Select(x => x.Key)
//      .ToList();

//    list = list.OrderBy(x => x).ToList();
//    Console.WriteLine(string.Join(" ", list));
//  }
//}
