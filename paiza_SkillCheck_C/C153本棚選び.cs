//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    int[] ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int A = ABC[0], B = ABC[1], C = ABC[2];
//    int N = int.Parse(Console.ReadLine());

//    int minPrice = 100001;
//    for (int i = 0; i < N; i++)
//    {
//      int[] bookShelf = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      int price = bookShelf[0];
//      int a5 = bookShelf[1], comic = bookShelf[2], bunko = bookShelf[3];
//      if (price < minPrice)
//      {
//        int capa = a5;
//        if (capa >= A)
//        {
//          capa -= A;
//          capa += comic;
//          if (capa >= B)
//          {
//            capa -= B;
//            capa += bunko;
//            if (capa >= C)
//            {
//              minPrice = price;
//            }
//          }
//        }
//      }
//    }
//    Console.WriteLine(minPrice == 100001 ? -1 : minPrice);
//  }
//}
