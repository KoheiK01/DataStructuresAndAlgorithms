//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Program
//{
//    static void Main()
//    {
//        //自分の得意な言語で
//        //Let's チャレンジ！！
//        int N = int.Parse(Console.ReadLine());
//        string lease1 = Console.ReadLine();
//        string lease2 = Console.ReadLine();
//        bool isEqual = false;

//        for (int i = 0; i < N; i++)
//        {
//            lease2 = Swap(lease2);

//            if (lease1 == lease2)
//            {
//                isEqual = true;
//                break;
//            }
//        }

//        if (isEqual)
//            Console.WriteLine("Yes");
//        else
//            Console.WriteLine("No");
//    }

//    static string Swap(string lease)
//    {
//        string swapedLease = lease[lease.Length - 1].ToString();
//        for (int i = 0; i < lease.Length - 1; i++)
//            swapedLease += lease[i].ToString();

//        return swapedLease;
//    }
//}