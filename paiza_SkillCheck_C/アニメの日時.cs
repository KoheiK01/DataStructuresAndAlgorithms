//using System;
//using System.Collections.Generic;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'S チャレンジ！
//    var words = Console.ReadLine().Split(' ');

//    var date = words[0].Split('/');
//    string month = date[0];
//    int day = int.Parse(date[1]);

//    var time = words[1].Split(':');
//    int hour = int.Parse(time[0]);
//    string minute = time[1];

//    int plusDay = hour / 24;
//    day += plusDay;
//    hour %= 24;
//    Console.WriteLine(month + "/" + day.ToString("00") + " " + hour.ToString("00") + ":" + minute);
//  }
//}