//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    string[] words = Console.ReadLine().Split();
//    int MenberMax = int.Parse(words[0]);
//    int RecordMax = int.Parse(words[1]);
//    int TopMax = int.Parse(words[2]);
//    List<Menber> menbers = new List<Menber>();
//    for (int menber = 0; menber < MenberMax; menber++)
//    {
//      words = Console.ReadLine().Split();
//      string name = words[0];
//      int distance = int.Parse(words[1]);
//      menbers.Add(new Menber(name, distance));
//    }

//    menbers = menbers
//        .OrderByDescending(menber => menber.PreDistance)
//        .ThenBy(menber => menber.Name)
//        .ToList();

//    for (int ranking = 0; ranking < TopMax; ranking++)
//    {
//      menbers[ranking].PreRanking = ranking + 1;
//    }

//    for (int record = 0; record < RecordMax; record++)
//    {
//      words = Console.ReadLine().Split();
//      int date = int.Parse(words[0]);
//      string name = words[1];
//      int distance = int.Parse(words[2]);

//      int index = menbers.FindIndex(menber => menber.Name == name);
//      menbers[index].Distance += distance;
//    }

//    menbers = menbers
//        .OrderByDescending(menber => menber.Distance)
//        .ThenBy(menber => menber.Name)
//        .ToList();

//    for (int ranking = 0; ranking < TopMax; ranking++)
//    {
//      string change;
//      if (menbers[ranking].PreRanking == 0)
//        change = "new";
//      else if (menbers[ranking].PreRanking < ranking + 1)
//        change = "down";
//      else if (menbers[ranking].PreRanking == ranking + 1)
//        change = "same";
//      else
//        change = "up";
//      Console.WriteLine(menbers[ranking].Name + " " + menbers[ranking].Distance + " " + change);
//    }
//  }
//}

//public class Menber
//{
//  public string Name;
//  public int PreDistance;
//  public int Distance;
//  public int PreRanking = 0;

//  public Menber(string name, int preDistance)
//  {
//    Name = name;
//    PreDistance = preDistance;
//  }
//}