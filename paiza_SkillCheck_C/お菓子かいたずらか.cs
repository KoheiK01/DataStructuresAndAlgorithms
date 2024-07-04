//using System;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    var words = Console.ReadLine().Split(' ');
//    int n = int.Parse(words[0]);
//    int m = int.Parse(words[1]);
//    int k = int.Parse(words[2]);
//    int[] bushs = new int[m];
//    for (int i = 0; i < m; i++)
//    {
//      bushs[i] = int.Parse(Console.ReadLine());
//    }
//    if (m == 0)
//    {
//      bushs = new int[1];
//    }

//    int num = 0;
//    int cont = 0;
//    int index = 0;
//    for (int i = 1; i <= n; i++)
//    {
//      if (i == bushs[index])
//      {
//        index = Math.Min(index + 1, m - 1);
//        cont++;
//        if (cont == k)
//        {
//          break;
//        }
//      }
//      else
//      {
//        cont = 0;
//        num++;
//      }
//    }
//    Console.WriteLine(num);
//  }
//}