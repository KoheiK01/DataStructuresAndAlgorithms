//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        int[] distances = { 12, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
//        string S = Console.ReadLine();
//        int ans = 0;

//        for (int i = 0; i < S.Length; i++)
//        {
//            if (S[i] != '-')
//            {
//                int input = int.Parse(S[i].ToString());
//                ans += distances[input] * 2;
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}