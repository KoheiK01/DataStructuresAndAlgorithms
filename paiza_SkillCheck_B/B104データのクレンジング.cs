//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
//    int N = _firstLine[0], M = _firstLine[1];
//    List<int>[] _answers = new List<int>[M];
//    for (int i = 0; i < M; i++)
//    {
//      _answers[i] = new List<int>();
//    }
//    for (int i = 0; i < N; i++)
//    {
//      string[] _inputs = Console.ReadLine().Trim().Split();
//      for (int j = 0; j < M; j++)
//      {
//        if (int.TryParse(_inputs[j], out int _answer))
//        {
//          if (0 <= _answer && _answer <= 100)
//          {
//            _answers[j].Add(_answer);
//          }
//        }
//      }
//    }
//    for (int i = 0; i < M; i++)
//    {
//      if (_answers[i].Count == 0)
//      {
//        Console.WriteLine(0);
//      }
//      else
//      {
//        Console.WriteLine((int)Math.Floor(_answers[i].Average()));
//      }
//    }
//  }
//}