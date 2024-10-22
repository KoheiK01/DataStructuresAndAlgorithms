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
//        int a = int.Parse(words[0]);
//        int b = int.Parse(words[1]);
//        int N = int.Parse(Console.ReadLine());

//        for (int i = 0; i < N; i++)
//        {
//            words = Console.ReadLine().Split();
//            int A = int.Parse(words[0]);
//            int B = int.Parse(words[1]);
//            if (a > A)
//            {
//                Console.WriteLine("High");
//            }
//            else if (a == A)
//            {
//                if (b < B)
//                    Console.WriteLine("High");
//                else
//                    Console.WriteLine("Low");
//            }
//            else
//            {
//                Console.WriteLine("Low");
//            }
//        }
//    }
//}