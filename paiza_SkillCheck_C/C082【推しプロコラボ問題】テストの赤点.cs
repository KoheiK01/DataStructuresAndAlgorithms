//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    int X = firstLine[0];
//    int Y = firstLine[1];

//    List<Test> tests = new List<Test>();
//    for (int x = 0; x < X; x++)
//    {
//      var scores = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//      tests.Add(new Test()
//      {
//        EngScore = scores[0],
//        JapScore = scores[1],
//        MatScore = scores[2]
//      });
//    }

//    int engRedLine = tests.OrderBy(x => x.EngScore).ToList()[Y - 1].EngScore;
//    int japRedLine = tests.OrderBy(x => x.JapScore).ToList()[Y - 1].JapScore;
//    int matRedLine = tests.OrderBy(x => x.MatScore).ToList()[Y - 1].MatScore;


//    foreach (var item in tests)
//    {
//      int redScoreNum = 0;
//      if (item.EngScore <= engRedLine) redScoreNum++;
//      if (item.JapScore <= japRedLine) redScoreNum++;
//      if (item.MatScore <= matRedLine) redScoreNum++;
//      Console.WriteLine(redScoreNum.ToString());
//    }
//  }
//}

//class Test
//{
//  public int EngScore;
//  public int JapScore;
//  public int MatScore;
//}
