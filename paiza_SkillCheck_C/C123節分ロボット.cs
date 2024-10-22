//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    int n = int.Parse(Console.ReadLine());
//    Human[] humans = new Human[n];
//    for (int i = 0; i < n; i++)
//    {
//      int old = int.Parse(Console.ReadLine());
//      Human human = new Human() { Old = old, HaveBeans = 0 };
//      humans[i] = human;
//    }

//    int orderNum = int.Parse(Console.ReadLine());
//    for (int i = 0; i < orderNum; i++)
//    {
//      var words = Console.ReadLine().Split(' ');
//      int a = int.Parse(words[0]);
//      int b = int.Parse(words[1]);
//      int c = int.Parse(words[2]);

//      for (int j = a - 1; j < b; j++)
//      {
//        humans[j].GetBeans(c);
//      }
//    }

//    Array.ForEach(humans, human =>
//    {
//      Console.WriteLine(human.HaveBeans);
//    });
//  }
//}

//class Human
//{
//  public int Old;
//  public int HaveBeans;

//  public void GetBeans(int beans)
//  {
//    HaveBeans = Math.Min(Old, HaveBeans + beans);
//  }
//}