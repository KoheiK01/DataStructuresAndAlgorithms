//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** ハッシュ関数を作ってみよう **************/
//    //int n = int.Parse(Console.ReadLine());
//    //int[] nmod = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = nmod[0], mod = nmod[1];
//    //int[] nabmod = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = nabmod[0], a = nabmod[1], b = nabmod[2], mod = nabmod[3];
//    //for (int i = 0; i < n; i++)
//    //{
//    //int x = int.Parse(Console.ReadLine());
//    //HashFunction1(x, mod);
//    //HashFunction2(x, a, b, mod);
//    //string x = Console.ReadLine();
//    //HashFunction3(x);
//    //  HashFunction4(x);
//    //}

//    /********** ハッシュテーブルを使おう **************/
//    //STEP: 1 ハッシュテーブル(オープンアドレス法)
//    //int n = int.Parse(Console.ReadLine());
//    //HashTable table = new HashTable();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int x = int.Parse(Console.ReadLine());
//    //  table.InsertOpenAdress(x);
//    //}
//    //table.PrintOpenTable();

//    //STEP: 2 ハッシュテーブル(チェイン法)
//    //int n = int.Parse(Console.ReadLine());
//    //HashTable table = new HashTable();
//    //for (int i = 0; i < n; i++)
//    //{
//    //  int x = int.Parse(Console.ReadLine());
//    //  table.InsertChain1(x);
//    //}
//    //table.PrintHashTable();

//    //FINAL問題 ハッシュテーブルを使おう
//    //int[] ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int a = ab[0], b = ab[1];
//    //int q = int.Parse(Console.ReadLine());
//    //HashTable table = new HashTable();
//    //for (int i = 0; i < q; i++)
//    //{
//    //  int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  if (query[0] == 1)
//    //  {
//    //    table.InsertChain2(query[1], a, b);
//    //  }
//    //  else
//    //  {
//    //    Console.WriteLine(table.HashSerch(query[1], a, b) ? "Yes" : "No");
//    //  }
//    //}
//    //table.PrintHashTable();
//  }

//  private static void HashFunction1(int x, int mod) => Console.WriteLine(x % mod);
//  private static void HashFunction2(int x, int a, int b, int mod)
//    => Console.WriteLine((a * x + b) % mod);
//  private static void HashFunction3(string x)
//    => Console.WriteLine(
//      x.Count(i => i == 'p') +
//      x.Count(i => i == 'a') +
//      x.Count(i => i == 'i') +
//      x.Count(i => i == 'z'));
//  private static void HashFunction4(string x)
//  {
//    int hash = 0;
//    for (int i = 0; i < x.Length; i++)
//    {
//      hash += i * x[i];
//    }
//    Console.WriteLine(hash % 100);
//  }
//}

//public class HashTable
//{
//  private const int SIZE = 100;
//  private int[] openTable;
//  private List<int>[] chainTable = new List<int>[SIZE];

//  public HashTable()
//  {
//    openTable = Enumerable.Repeat(-1, SIZE).ToArray();
//    for (int i = 0; i < SIZE; i++)
//    {
//      chainTable[i] = new List<int>();
//    }
//  }

//  public void InsertOpenAdress(int x)
//  {
//    int hash = x % SIZE;
//    while (openTable[hash] != -1)
//    {
//      hash = (hash + 1) % SIZE;
//    }
//    openTable[hash] = x;
//  }

//  public void InsertChain1(int x)
//  {
//    int hash = x % SIZE;
//    chainTable[hash].Add(x);
//  }

//  public void InsertChain2(int x, int a, int b)
//  {
//    int hash = (a * x + b) % SIZE;
//    chainTable[hash].Add(x);
//  }

//  public bool HashSerch(int x, int a, int b)
//  {
//    int hash = (a * x + b) % SIZE;
//    return chainTable[hash].Contains(x);
//  }

//  public void PrintOpenTable()
//  {
//    Console.WriteLine(string.Join("\n", openTable));
//  }

//  public void PrintHashTable()
//  {
//    for (int i = 0; i < SIZE; i++)
//    {
//      Console.WriteLine(string.Join(" ", chainTable[i]));
//    }
//  }
//}
