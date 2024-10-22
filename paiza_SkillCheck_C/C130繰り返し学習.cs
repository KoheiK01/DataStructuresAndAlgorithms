//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        int N = int.Parse(Console.ReadLine());
//        bool[] doMistake = new bool[N];
//        int count = 0;

//        for (int i = 0; i < N; i++)
//        {
//            string[] words = Console.ReadLine().Split();
//            if (words[0] == "n" || words[1] == "n")
//            {
//                doMistake[i] = true;
//                count++;
//            }
//        }
//        Console.WriteLine(count);

//        for (int i = 0; i < N; i++)
//        {
//            if (doMistake[i])
//                Console.WriteLine(i + 1);
//        }
//    }
//}