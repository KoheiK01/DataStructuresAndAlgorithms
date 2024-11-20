//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** ロボットの暴走 **********/
//    //FINAL問題 ロボットの暴走
//    int[] HWNK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int H = HWNK[0], W = HWNK[1], N = HWNK[2], K = HWNK[3];

//    Robot[] _robots = new Robot[N];

//    bool[,] _map = new bool[H, W];
//    for (int i = 0; i < 10; i++)
//    {
//      int[] _xy = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      _map[_xy[1], _xy[0]] = true;
//    }

//    for (int i = 0; i < N; i++)
//    {
//      int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      int _x = _line[0], _y = _line[1], _level = _line[2];
//      _robots[i] = new Robot(_x, _y, _level);
//    }

//    for (int i = 0; i < K; i++)
//    {
//      string[] _words = Console.ReadLine().Split();
//      int _id = int.Parse(_words[0]) - 1;
//      _robots[_id].Move(_words[1]);
//      _robots[_id].LevelUp(_map, H, W);
//    }

//    foreach (var _robot in _robots)
//    {
//      Console.WriteLine(_robot.ToFormat());
//    }
//  }
//}

////FINAL問題 ロボットの暴走
//public class Robot
//{
//  private int x;
//  private int y;
//  private int level;
//  private int[] distances = { 0, 1, 2, 5, 10 };

//  public Robot(int _x, int _y, int _level)
//  {
//    x = _x;
//    y = _y;
//    level = _level;
//  }

//  public string ToFormat()
//  {
//    return $"{x} {y} {level}";
//  }

//  public void LevelUp(bool[,] _map, int H, int W)
//  {
//    if (IsInside(H, W) && _map[y, x])
//    {
//      level = Math.Min(4, level + 1);
//    }
//  }

//  private bool IsInside(int H, int W)
//  {
//    return 0 <= x && x < W && 0 <= y && y < H;
//  }

//  public void Move(string _direction)
//  {
//    int _distance = distances[level];
//    switch (_direction)
//    {
//      case "N":
//        y -= _distance;
//        break;
//      case "E":
//        x += _distance;
//        break;
//      case "S":
//        y += _distance;
//        break;
//      case "W":
//        x -= _distance;
//        break;
//    }
//  }
//}