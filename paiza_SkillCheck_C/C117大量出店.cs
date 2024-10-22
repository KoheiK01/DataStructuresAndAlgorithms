//using System;
//class Program
//{
//    static void Main()
//    {
//        // 自分の得意な言語で
//        // Let's チャレンジ！！
//        string[] words = Console.ReadLine().Split();
//        int N = int.Parse(words[0]);
//        int M = int.Parse(words[1]);

//        words = Console.ReadLine().Split();
//        int A = int.Parse(words[0]);
//        int B = int.Parse(words[1]);
//        int C = int.Parse(words[2]);

//        int closeCount = 0;
//        int cost = A + B * M;

//        for (int i = 0; i < N; i++)
//        {
//            int profit = int.Parse(Console.ReadLine()) * C;
//            if (profit < cost)
//                closeCount++;
//        }

//        Console.WriteLine(closeCount);
//    }
//}