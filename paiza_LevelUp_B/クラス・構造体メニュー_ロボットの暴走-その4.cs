//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** ロボットの暴走 **********/
//    //STEP: 4 スーパースーパースーパーカー
//    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int N = NK[0], K = NK[1];
//    Robot[] _superCars = new Robot[N];
//    for (int i = 0; i < N; i++)
//    {
//      string[] _words = Console.ReadLine().Split();
//      int _liter = int.Parse(_words[1]);
//      int _fuelEfficiency = int.Parse(_words[2]);
//      switch (_words[0])
//      {
//        case "supercar":
//          _superCars[i] = new Robot(_liter, _fuelEfficiency);
//          break;
//        case "supersupercar":
//          _superCars[i] = new SuperSuperCar(_liter, _fuelEfficiency);
//          break;
//        case "supersupersupercar":
//          _superCars[i] = new SuperSuperSuperCar(_liter, _fuelEfficiency);
//          break;
//      }
//    }
//    for (int i = 0; i < K; i++)
//    {
//      string[] _words = Console.ReadLine().Split();
//      int _id = int.Parse(_words[0]) - 1;
//      switch (_words[1])
//      {
//        case "run":
//          _superCars[_id].Run();
//          break;
//        case "fly":
//          _superCars[_id].Fly();
//          break;
//        case "teleport":
//          _superCars[_id].Teleport();
//          break;
//      }
//    }
//    foreach (var _car in _superCars)
//    {
//      Console.WriteLine(_car.Distance);
//    }
//  }
//}

////STEP: 4 スーパースーパースーパーカー
//public class Robot
//{
//  protected int liter;
//  protected int fuelEfficiency;
//  public int Distance;

//  public Robot(int _liter, int _fuelEfficiency)
//  {
//    liter = _liter;
//    fuelEfficiency = _fuelEfficiency;
//    Distance = 0;
//  }

//  public void Run()
//  {
//    if (liter >= 1)
//    {
//      liter--;
//      Distance += fuelEfficiency;
//    }
//  }

//  public virtual void Fly() { }
//  public virtual void Teleport() { }
//}

//public class SuperSuperCar : Robot
//{
//  public SuperSuperCar(int _l, int _f) : base(_l, _f) { }

//  public override void Fly()
//  {
//    if (liter >= 5)
//    {
//      liter -= 5;
//      Distance += (int)Math.Pow(fuelEfficiency, 2);
//    }
//    else
//    {
//      Run();
//    }
//  }
//}

//public class SuperSuperSuperCar : SuperSuperCar
//{
//  public SuperSuperSuperCar(int _l, int _f) : base(_l, _f) { }

//  public override void Teleport()
//  {
//    if (liter >= (int)Math.Pow(fuelEfficiency, 2))
//    {
//      liter -= (int)Math.Pow(fuelEfficiency, 2);
//      Distance += (int)Math.Pow(fuelEfficiency, 4);
//    }
//    else
//    {
//      Fly();
//    }
//  }

//  public override void Fly()
//  {
//    if (liter >= 5)
//    {
//      liter -= 5;
//      Distance += 2 * (int)Math.Pow(fuelEfficiency, 2);
//    }
//    else
//    {
//      Run();
//    }
//  }
//}