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

//        List<int> Time = new List<int>();

//        for (int i = 0; i < N; i++)
//        {
//            string[] words = Console.ReadLine().Split();
//            int s = int.Parse(words[0]);
//            int f = int.Parse(words[1]);
//            int t = int.Parse(words[2]);

//            Time.Add(s);
//            Time[i] += f;
//            Time[i] += 24 - t;
//        }

//        Console.WriteLine(Time.Min());
//        Console.WriteLine(Time.Max());
//    }
//}