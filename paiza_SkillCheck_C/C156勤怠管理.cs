//using System;

//class Program
//{
//  static void Main()
//  {
//    int N = int.Parse(Console.ReadLine());

//    int totalMinutes = 0; int totalHours = 0;
//    for (int i = 0; i < N; i++)
//    {
//      var _el = Console.ReadLine().Split();
//      var start = _el[0].Split(':');
//      var end = _el[1].Split(':');
//      int startHour = int.Parse(start[0]);
//      int startMinute = int.Parse(start[1]);
//      int endHour = int.Parse(end[0]);
//      int endMinute = int.Parse(end[1]);

//      if (endMinute < startMinute)
//      {
//        endHour--;
//        endMinute += 60;
//      }
//      totalMinutes += endMinute - startMinute;
//      totalHours += endHour - startHour;
//    }

//    totalHours += totalMinutes / 60;
//    totalMinutes %= 60;
//    Console.WriteLine(totalHours + " " + totalMinutes);
//  }
//}
