//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        // 自分の得意な言語で
//        // Let's チャレンジ！！
//        int N = int.Parse(Console.ReadLine());
//        string nowWord;
//        string preWord = "";

//        for (int i = 0; i < N; i++)
//        {
//            nowWord = Console.ReadLine();
//            if (i != 0 &&
//                preWord[preWord.Length - 1] != nowWord[0])
//            {
//                Console.Write(
//                    preWord[preWord.Length - 1] + " ");
//                Console.WriteLine(
//                    nowWord[0]);
//                break;
//            }
//            else if (i == N - 1)
//                Console.WriteLine("Yes");

//            preWord = nowWord;
//        }
//    }
//}