using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
  static void Main()
  {
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int n = int.Parse(Console.ReadLine());
    var words = Console.ReadLine().Split(' ');

    List<int> list = new List<int>();
    for (int i = 0; i < n; i++)
    {
      list.Add(int.Parse(words[i]));
    }
    list.Sort();
    list.RemoveAt(0);
    list.RemoveAt(list.Count - 1);
    double ave = list.Average();
    ave = Math.Floor(ave * 10) / 10;

    Console.WriteLine(ave.ToString("f1"));
  }
}