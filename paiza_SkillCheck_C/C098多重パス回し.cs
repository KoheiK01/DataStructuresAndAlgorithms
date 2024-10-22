//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        int persons = int.Parse(Console.ReadLine());
//        int[] balls = new int[persons];

//        for (int i = 0; i < persons; i++)
//        {
//            int ball = int.Parse(Console.ReadLine());
//            balls[i] = ball;
//        }

//        int passes = int.Parse(Console.ReadLine());
//        for (int i = 0; i < passes; i++)
//        {
//            string[] words = Console.ReadLine().Split();
//            int fromPerson = int.Parse(words[0]);
//            int toPerson = int.Parse(words[1]);
//            int ball = int.Parse(words[2]);

//            if (ball > balls[fromPerson - 1])
//            {
//                balls[toPerson - 1] += balls[fromPerson - 1];
//                balls[fromPerson - 1] = 0;
//            }
//            else
//            {
//                balls[toPerson - 1] += ball;
//                balls[fromPerson - 1] -= ball;
//            }
//        }

//        for (int i = 0; i < persons; i++)
//        {
//            Console.WriteLine(balls[i]);
//        }
//    }
//}