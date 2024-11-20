//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 静的メンバ **********/
//    //STEP: 4 クラスの継承
//    //STEP: 5 デフォルト引数
//    //FINAL問題 静的メンバ
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //int leaveCount = 0;
//    //List<Customer> _customers = new List<Customer>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int age = int.Parse(Console.ReadLine());
//    //  if (age < 20)
//    //  {
//    //    _customers.Add(new Customer(age));
//    //  }
//    //  else
//    //  {
//    //    _customers.Add(new AdultCustomer(age));
//    //  }
//    //}

//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split();
//    //  int n = int.Parse(words[0]) - 1;
//    //  string order = words[1];
//    //  switch (order)
//    //  {
//    //    case "food":
//    //      int amount = int.Parse(words[2]);
//    //      _customers[n].OrderFood(amount);
//    //      break;
//    //    case "softdrink":
//    //      amount = int.Parse(words[2]);
//    //      _customers[n].OrderSoftDrink(amount);
//    //      break;
//    //    case "alcohol":
//    //      amount = int.Parse(words[2]);
//    //      _customers[n].OrderAlcohol(amount);
//    //      break;
//    //    case "0":
//    //      amount = 500;
//    //      _customers[n].OrderAlcohol(500);
//    //      break;
//    //    case "A":
//    //      Console.WriteLine(_customers[n].TotalAmount);
//    //      leaveCount++;
//    //      break;
//    //  }
//    //}
//    //Console.WriteLine(leaveCount);
//    //_customers.ForEach(_customer =>
//    //{
//    //  Console.WriteLine(_customer.TotalAmount);
//    //});
//  }
//}

////STEP: 4 クラスの継承
////STEP: 5 デフォルト引数
////FINAL問題 静的メンバ
////public class Customer
////{
////  public int Age;
////  public int TotalAmount = 0;
////  public Customer(int _age)
////  {
////    Age = _age;
////  }
////  public virtual void OrderFood(int amount) => TotalAmount += amount;
////  public void OrderSoftDrink(int amount) => TotalAmount += amount;
////  public virtual void OrderAlcohol(int amount) { }
////}

////public class AdultCustomer : Customer
////{
////  public bool Drunk = false;
////  public AdultCustomer(int _age) : base(_age) { }
////  public override void OrderFood(int amount) => TotalAmount += Drunk ? amount - 200 : amount;
////  public override void OrderAlcohol(int amount)
////  {
////    TotalAmount += amount;
////    Drunk = true;
////  }
////}
