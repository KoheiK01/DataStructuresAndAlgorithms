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
//        int origami = int.Parse(words[0]);
//        int length = int.Parse(words[1]);
//        int allLength = length;

//        for (int i = 1; i < origami; i++)
//        {
//            int overlap = int.Parse(Console.ReadLine());
//            allLength += length - overlap;
//        }

//        Console.WriteLine(allLength * length);
//    }
//}