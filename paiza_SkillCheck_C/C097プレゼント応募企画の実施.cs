//using System;
//class Program
//{
//    static void Main()
//    {
//        // 自分の得意な言語で
//        // Let's チャレンジ！！
//        string[] splits = Console.ReadLine().Split(' ');
//        int N = int.Parse(splits[0]);
//        int X = int.Parse(splits[1]);
//        int Y = int.Parse(splits[2]);
//        string output;

//        for (int num = 1; num <= N; num++)
//        {
//            if ((num % X == 0) && (num % Y == 0))
//                output = "AB";
//            else if (num % X == 0)
//                output = "A";
//            else if (num % Y == 0)
//                output = "B";
//            else
//                output = "N";
//            Console.WriteLine(output);
//        }

//    }
//}