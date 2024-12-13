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
//    //STEP: 1 スタック・キュー実装編( 共通問題 ) step 1
//    //int N = int.Parse(Console.ReadLine());
//    //Queue<int> queue1 = new Queue<int>();
//    //int[] A = new int[N];
//    //for (int item = 0; item < N; item++)
//    //{
//    //  queue1.Enqueue(int.Parse(Console.ReadLine()));
//    //}
//    //Console.WriteLine(queue1.Count);
//    //Console.WriteLine(string.Join("\n", queue1.ToArray()));

//    //FINAL問題 スタック・キュー実装編( 共通問題 ) step 2
//    //Queue<int> queue1 = new Queue<int>();
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int item = 0; item < Q; item++)
//    //{
//    //  int[] query = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //  if (query[0] == 1)
//    //  {
//    //    queue1.Enqueue(query[1]);
//    //  }
//    //}
//    //Console.WriteLine(queue1.Count);
//    //Console.WriteLine(string.Join("\n", queue1.ToArray()));

//    /********** スタック実装編 step 2 **************/
//    //STEP: 1 スタック実装編 step 1
//    //FINAL問題 スタック実装編 step 2
//    //Stack<string> stack = new Stack<string>();
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int item = 0; item < Q; item++)
//    //{
//    //  string[] query = Console.ReadLine().Split();
//    //  switch (query[0])
//    //  {
//    //    case "1":
//    //      stack.Push(query[1]);
//    //      break;
//    //    case "2":
//    //      stack.Pop();
//    //      Console.WriteLine(stack.Pop());
//    //      break;
//    //  }
//    //  Console.WriteLine(string.Join(" ", stack.Reverse()));
//    //}

//    /********** キュー実装編 step 2 **************/
//    //STEP: 1 キュー実装編 step 1
//    //FINAL問題 キュー実装編 step 2
//    //Queue<string> queue1 = new Queue<string>();
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int item = 0; item < Q; item++)
//    //{
//    //  string[] query = Console.ReadLine().Split();
//    //  switch (query[0])
//    //  {
//    //    case "1":
//    //      queue1.Enqueue(query[1]);
//    //      break;
//    //    case "2":
//    //      queue1.Dequeue();
//    //      Console.WriteLine(queue1.Dequeue());
//    //      break;
//    //  }
//    //  Console.WriteLine(string.Join(" ", queue1));
//    //}

//    /********** 箱とボール **************/
//    //STEP: 1 2 つのキュー
//    //Queue<string> queue1 = new Queue<string>();
//    //Queue<string> queue2 = new Queue<string>();
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int item = 0; item < Q; item++)
//    //{
//    //  string[] query = Console.ReadLine().Split();
//    //  switch (query[0])
//    //  {
//    //    case "1":
//    //      if (query[1] == "1") { queue1.Enqueue(query[2]); }
//    //      else { queue2.Enqueue(query[2]); }
//    //      break;
//    //    case "2":
//    //      if (query[1] == "1") { Console.WriteLine(queue1.Dequeue()); }
//    //      else { Console.WriteLine(queue2.Dequeue()); }
//    //      break;
//    //    case "3":
//    //      Console.WriteLine($"{queue1.Count} {queue2.Count}");
//    //      break;
//    //  }
//    //}

//    //STEP: 2 最大の区間和
//    //int[] nX = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int n = nX[0], x = nX[1];
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int sum = A.Take(x).Sum();
//    //int max = sum;
//    //int left = A[0];
//    //for (int item = 1; item < n - x + 1; item++)
//    //{
//    //  sum -= A[item - 1];
//    //  sum += A[item + x - 1];
//    //  if (sum > max)
//    //  {
//    //    max = sum;
//    //    left = A[item];
//    //  }
//    //}
//    //Console.WriteLine($"{max} {left}");

//    //STEP: 3 逆ポーランド記法
//    //Stack<string> stack = new Stack<string>();
//    //int n = int.Parse(Console.ReadLine());
//    //string[] A = Console.ReadLine().Split();
//    //for (int item = 0; item < n; item++)
//    //{
//    //  int a, b;
//    //  switch (A[item])
//    //  {
//    //    case "+":
//    //      b = int.Parse(stack.Pop());
//    //      a = int.Parse(stack.Pop());
//    //      stack.Push((a + b).ToString());
//    //      break;
//    //    case "-":
//    //      b = int.Parse(stack.Pop());
//    //      a = int.Parse(stack.Pop());
//    //      stack.Push((a - b).ToString());
//    //      break;
//    //    default:
//    //      stack.Push(A[item]);
//    //      break;
//    //  }
//    //}
//    //Console.WriteLine(stack.Pop());

//    //STEP: 4 括弧列
//    //int N = int.Parse(Console.ReadLine());
//    //string S = Console.ReadLine();
//    //Stack<string> stack = new Stack<string>();
//    //for (int item = 0; item < N; item++)
//    //{
//    //  if (S[item].ToString() == ")" && stack.Count > 0 && stack.Peek() == "(")
//    //  {
//    //    stack.Pop();
//    //  }
//    //  else
//    //  {
//    //    stack.Push(S[item].ToString());
//    //  }
//    //}
//    //Console.WriteLine(stack.Count == 0 ? "Yes" : "No");

//    //STEP: 5 エスカレーター
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Queue<int> queue = new Queue<int>();
//    //for (int item = 0; item < K; item++)
//    //{
//    //  queue.Enqueue(0);
//    //}
//    //int index = 0;
//    //int count = 0;
//    //for (int time = 1; time <= A.Last(); time++)
//    //{
//    //  queue.Dequeue();
//    //  if (A[index] == time)
//    //  {
//    //    count++;
//    //    index++;
//    //    queue.Enqueue(1);
//    //    Console.WriteLine(queue.Sum());
//    //  }
//    //  else
//    //  {
//    //    queue.Enqueue(0);
//    //  }
//    //}

//    //FINAL問題 箱とボール
//    //int N = int.Parse(Console.ReadLine());
//    //int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //Stack<int> stack = new Stack<int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int ai = A[i];
//    //  while (stack.Count > 0 && ai == stack.Peek())
//    //  {
//    //    stack.Pop();
//    //    ai *= 2;
//    //  }
//    //  stack.Push(ai);
//    //}
//    //foreach (int item in stack) { Console.WriteLine(item); }
//  }
//}