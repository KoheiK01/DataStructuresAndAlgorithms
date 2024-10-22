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
//        int orderNum = int.Parse(words[0]);
//        int MaxCol = int.Parse(words[1]);
//        int count = 0;

//        for (int i = 0; i < orderNum; i++)
//        {
//            words = Console.ReadLine().Split();
//            int rank = int.Parse(words[0]);
//            int col = int.Parse(words[1]);

//            MaxCol -= col;
//            if (MaxCol < 0)
//                break;

//            if (rank <= 10)
//                count++;
//        }

//        if (count == 10)
//            Console.WriteLine("Yes");

//        else
//            Console.WriteLine(count);
//    }
//}