//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        // 自分の得意な言語で
//        // Let's チャレンジ！！
//        int M = int.Parse(Console.ReadLine());
//        bool[] LiveA = new bool[31];
//        for (int i = 0; i < M; i++)
//        {
//            LiveA[int.Parse(Console.ReadLine()) - 1] = true;
//        }

//        int N = int.Parse(Console.ReadLine());
//        bool[] LiveB = new bool[31];
//        for (int i = 0; i < N; i++)
//        {
//            LiveB[int.Parse(Console.ReadLine()) - 1] = true;
//        }

//        string nextLive = "A";

//        for (int i = 0; i < 31; i++)
//        {
//            if (LiveA[i] && LiveB[i])
//            {
//                Console.WriteLine(nextLive);
//                if (nextLive == "A")
//                    nextLive = "B";
//                else if (nextLive == "B")
//                    nextLive = "A";
//            }

//            else if (LiveA[i])
//            {
//                Console.WriteLine("A");
//            }

//            else if (LiveB[i])
//            {
//                Console.WriteLine("B");
//            }

//            else
//            {
//                Console.WriteLine("x");
//            }
//        }
//    }
//}