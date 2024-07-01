//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        string[] words = Console.ReadLine().Split();
//        int remain = int.Parse(words[0]);
//        int M = int.Parse(words[1]);
//        int point = 0;

//        for (int i = 0; i < M; i++)
//        {
//            int fare = int.Parse(Console.ReadLine());
//            if (point >= fare)
//            {
//                point -= fare;
//            }
//            else
//            {
//                remain -= fare;
//                point += fare / 10;
//            }

//            Console.WriteLine(remain + " " + point);
//        }
//    }
//}