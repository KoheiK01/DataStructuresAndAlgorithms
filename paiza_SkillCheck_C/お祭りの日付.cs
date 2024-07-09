//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    var words = Console.ReadLine().Split(' ');
//    int nowY = int.Parse(words[0]);
//    int nowM = int.Parse(words[1]);
//    int nowD = int.Parse(words[2]);

//    words = Console.ReadLine().Split(' ');
//    int a = int.Parse(words[0]);
//    int b = int.Parse(words[1]);

//    int[] daysInMonth = new int[13];
//    for (int month = 1; month <= 13; month++)
//    {
//      if (month % 2 == 0)
//      {
//        daysInMonth[month - 1] = 15;
//      }
//      else
//      {
//        daysInMonth[month - 1] = 13;
//      }
//    }

//    int count = 0;
//    count += daysInMonth[nowM - 1] - nowD;
//    for (int month = nowM + 1; month <= 13; month++)
//    {
//      count += daysInMonth[month - 1];
//    }

//    int year = nowY + 1;
//    while (year % 4 != 1)
//    {
//      count += daysInMonth.Sum();
//      year++;
//    }

//    for (int month = 1; month < a; month++)
//    {
//      count += daysInMonth[month - 1];
//    }
//    count += b;

//    Console.WriteLine(count.ToString());
//  }
//}
