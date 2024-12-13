//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** スタック・キュー実装編( 共通問題 ) step 2 **************/
//    //STEP: 1 双方向リスト実装編 step 1
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NQ[0], P = NQ[1], X = NQ[2];
//    //int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NQ[0], P = NQ[1];
//    //int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NQ[0], L = NQ[1], R = NQ[2];
//    //int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NQ[0], Q = NQ[1];
//    //LinkedList<int> list = new LinkedList<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  list.AddLast(int.Parse(Console.ReadLine()));
//    //}
//    //for (int j = 0; j < N; j++)
//    //{
//    //  list.AddFirst(int.Parse(Console.ReadLine()));
//    //}
//    //for (int j = 0; j < K; j++)
//    //{
//    //  list.RemoveLast();
//    //}
//    //for (int j = 0; j < K; j++)
//    //{
//    //  list.RemoveFirst();
//    //}
//    //LinkedListNode<int> curNode;
//    //if (P <= N)
//    //{
//    //  curNode = list.First;
//    //  for (int j = 1; j < P; j++)
//    //  {
//    //    curNode = curNode.Next;
//    //  }
//    //  list.AddBefore(curNode, X);
//    //}
//    //else
//    //{
//    //  list.AddLast(X);
//    //}
//    //curNode = list.First;
//    //for (int j = 1; j < P; j++)
//    //{
//    //  curNode = curNode.Next;
//    //}
//    //list.Remove(curNode);
//    //curNode = list.First;
//    //for (int j = 1; j < L; j++)
//    //{
//    //  curNode = curNode.Next;
//    //}
//    //for (int j = L; j < R; j++)
//    //{
//    //  LinkedListNode<int> nextNode = curNode.Next;
//    //  list.Remove(curNode);
//    //  curNode = nextNode;
//    //}
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  string[] query = Console.ReadLine().Split();
//    //  switch (query[0])
//    //  {
//    //    case "1":
//    //      int P = int.Parse(query[1]);
//    //      int X = int.Parse(query[2]);
//    //      if (P <= list.Count)
//    //      {
//    //        curNode = list.First;
//    //        for (int j = 1; j < P; j++)
//    //        {
//    //          curNode = curNode.Next;
//    //        }
//    //        list.AddBefore(curNode, X);
//    //      }
//    //      else
//    //      {
//    //        list.AddLast(X);
//    //      }
//    //      break;
//    //    case "2":
//    //      curNode = list.First;
//    //      P = int.Parse(query[1]);
//    //      for (int j = 1; j < P; j++)
//    //      {
//    //        curNode = curNode.Next;
//    //      }
//    //      list.Remove(curNode);
//    //      break;
//    //  }
//    //}
//    //curNode = list.First;
//    //while (curNode != null)
//    //{
//    //  Console.WriteLine(curNode.Value);
//    //  curNode = curNode.Next;
//    //}
//  }
//}
