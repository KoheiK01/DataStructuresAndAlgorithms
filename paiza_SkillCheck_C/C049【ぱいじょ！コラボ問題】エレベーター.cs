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
//        int result = 0;
//        int nowFloor = 1;
//        for (int i = 0; i < N; i++)
//        {
//            int Floor = int.Parse(Console.ReadLine());
//            result += Math.Abs(Floor - nowFloor);
//            nowFloor = Floor;
//        }

//        Console.WriteLine(result);
//    }
//}