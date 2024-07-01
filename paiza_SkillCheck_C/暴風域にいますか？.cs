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
//        int xc = int.Parse(words[0]);
//        int yc = int.Parse(words[1]);
//        int r1 = int.Parse(words[2]);
//        int r2 = int.Parse(words[3]);
//        int n = int.Parse(Console.ReadLine());

//        for (int i = 0; i < n; i++)
//        {
//            words = Console.ReadLine().Split();
//            int x = int.Parse(words[0]);
//            int y = int.Parse(words[1]);

//            double area = Math.Pow(x - xc, 2) + Math.Pow(y - yc, 2);

//            if (Math.Pow(r1, 2) <= area && area <= Math.Pow(r2, 2))
//            {
//                Console.WriteLine("yes");
//            }
//            else
//            {
//                Console.WriteLine("no");
//            }
//        }
//    }
//}