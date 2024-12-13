//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 双方向リスト実装編 完成 **************/
//    //STEP: 1 双方向リスト実装編 step 1
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] NP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NP[0], P = NP[1], X = NP[2];
//    //int[] NP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NP[0], P = NP[1];
//    //int[] NP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NP[0], L = NP[1], R = NP[2];
//    //int[] NP = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NP[0], Q = NP[1];

//    //LinkedList<int> list = new LinkedList<int>();
//    //AddLinkedListLasts(list, N);
//    //AddLinkedListFirsts(list, N);

//    //RemoveRangeLinekdList(list, list.Count - (K - 1), list.Count);
//    //RemoveRangeLinekdList(list, 1, K);
//    //RemoveRangeLinekdList(list, L, R - 1);
//    //RemoveAtPosition(list, P);

//    //InsertAtPositionWithBranching(list, P, X);

//    //for (int i = 0; i < Q; i++)
//    //{
//    //  string[] query = Console.ReadLine().Split();
//    //  switch (query[0])
//    //  {
//    //    case "1":
//    //      int P = int.Parse(query[1]);
//    //      int X = int.Parse(query[2]);
//    //      InsertAtPositionWithBranching(list, P, X);
//    //      break;
//    //    case "2":
//    //      P = int.Parse(query[1]);
//    //      RemoveAtPosition(list, P);
//    //      break;
//    //  }
//    //}

//    //PrintLinkedList(list);
//  }

//  private static void AddLinkedListLasts(LinkedList<int> list, int N)
//  {
//    for (int i = 0; i < N; i++)
//    {
//      list.AddLast(int.Parse(Console.ReadLine()));
//    }
//  }

//  private static void AddLinkedListFirsts(LinkedList<int> list, int N)
//  {
//    for (int i = 0; i < N; i++)
//    {
//      list.AddFirst(int.Parse(Console.ReadLine()));
//    }
//  }

//  private static void RemoveRangeLinekdList(LinkedList<int> list, int start, int end)
//  {
//    LinkedListNode<int> curNode = list.First;
//    for (int i = 1; i < start; i++)
//    {
//      curNode = curNode.Next;
//    }
//    for (int i = start; i <= end; i++)
//    {
//      LinkedListNode<int> nextNode = curNode.Next;
//      list.Remove(curNode);
//      curNode = nextNode;
//    }
//  }

//  private static void RemoveAtPosition(LinkedList<int> list, int P)
//  {
//    LinkedListNode<int> curNode = list.First;
//    for (int i = 1; i < P; i++)
//    {
//      curNode = curNode.Next;
//    }
//    list.Remove(curNode);
//  }

//  private static void InsertAtPositionWithBranching(LinkedList<int> list, int P, int X)
//  {
//    if (P <= list.Count)
//    {
//      LinkedListNode<int> curNode = list.First;
//      for (int i = 1; i < P; i++)
//      {
//        curNode = curNode.Next;
//      }
//      list.AddBefore(curNode, X);
//    }
//    else
//    {
//      list.AddLast(X);
//    }
//  }

//  private static void PrintLinkedList(LinkedList<int> list)
//  {
//    LinkedListNode<int> curNode = list.First;
//    while (curNode != null)
//    {
//      Console.WriteLine(curNode.Value);
//      curNode = curNode.Next;
//    }
//  }
//}
