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
//        int boxNum = int.Parse(words[0]);
//        int r = int.Parse(words[1]);

//        for (int i = 0; i < boxNum; i++)
//        {
//            words = Console.ReadLine().Split();
//            int h = int.Parse(words[0]);
//            int w = int.Parse(words[1]);
//            int d = int.Parse(words[2]);
//            int min = Math.Min(h, w);
//            min = Math.Min(min, d);
//            if (min >= 2 * r)
//                Console.WriteLine(i + 1);
//        }
//    }
//}