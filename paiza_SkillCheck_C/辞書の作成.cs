using System;
using System.Collections.Generic;
using System.ComponentModel;
class Program
{
  static void Main()
  {
    // 自分の得意な言語で
    // Let's チャレンジ！！
    var words = Console.ReadLine().Split(' ');
    int n = int.Parse(words[0]);
    int k = int.Parse(words[1]);
    int p = int.Parse(words[2]);
    string alpha = "abcdefghijklmnopqrstuvwxyz ";
    List<string> list = new List<string>();

    words = Console.ReadLine().Split(' ');
    for (int i = 0; i < n; i++)
    {
      list.Add(words[i]);
    }
    list.Sort();

    int page = 1;
    for (int i = 0; i < n; i++)
    {
      if (page == p)
      {
        Console.WriteLine(list[i]);
      }
      if ((i + 1) % k == 0)
      {
        page++;
      }
    }
  }
}
