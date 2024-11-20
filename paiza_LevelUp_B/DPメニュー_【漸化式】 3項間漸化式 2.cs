//using System;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【漸化式】 3項間漸化式 2 **********/
//    //STEP: 1 2項間漸化式 1
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int x = firstLine[0], d = firstLine[1], k = firstLine[2];
//    //int[] A = new int[k];
//    //A[0] = x;
//    //for (int i = 1; i < k; i++)
//    //{
//    //  A[i] = A[i - 1] + d;
//    //}
//    //Console.WriteLine(A[k - 1]);

//    //STEP: 2 2項間漸化式 2
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int x = firstLine[0], d = firstLine[1];
//    //int Q = int.Parse(Console.ReadLine());
//    //int[] A = new int[1000];
//    //A[0] = x;
//    //for (int i = 1; i < 1000; i++)
//    //{
//    //  A[i] = A[i - 1] + d;
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  int k = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(A[k - 1]);
//    //}

//    //STEP: 3 特殊な2項間漸化式 1
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int x = firstLine[0], d1 = firstLine[1], d2 = firstLine[2], k = firstLine[3];
//    //int[] A = new int[k];
//    //A[0] = x;
//    //for (int i = 1; i < k; i++)
//    //{
//    //  A[i] = (i + 1) % 2 == 0 ? A[i - 1] + d2 : A[i - 1] + d1;
//    //}
//    //Console.WriteLine(A[k - 1]);

//    //STEP: 4 特殊な2項間漸化式 2
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int x = firstLine[0], d1 = firstLine[1], d2 = firstLine[2];
//    //int Q = int.Parse(Console.ReadLine());
//    //int[] A = new int[1000];
//    //A[0] = x;
//    //for (int i = 1; i < 1000; i++)
//    //{
//    //  A[i] = (i + 1) % 2 == 0 ? A[i - 1] + d2 : A[i - 1] + d1;
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  int k =int.Parse(Console.ReadLine()); 
//    //  Console.WriteLine(A[k - 1]);
//    //}

//    //STEP: 5 3項間漸化式 1
//    //int k = int.Parse(Console.ReadLine());
//    //int[] A = new int[k];
//    //A[0] = A[1] = 1;
//    //for (int i = 2; i < k; i++)
//    //{
//    //  A[i] = A[i - 1] + A[i - 2];
//    //}
//    //Console.WriteLine(A[k - 1]);

//    //FINAL問題 【漸化式】 3項間漸化式 2
//    //int[] A = new int[40];
//    //A[0] = A[1] = 1;
//    //for (int i = 2; i < 40; i++)
//    //{
//    //  A[i] = A[i - 1] + A[i - 2];
//    //}
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  int k = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(A[k - 1]);
//    //}
//  }
//}
