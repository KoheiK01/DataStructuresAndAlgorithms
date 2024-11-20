//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** ロボットの暴走 **********/
//    //STEP: 2 RPG
//    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int N = NK[0], K = NK[1];
//    Brave[] _braves = new Brave[N];
//    for (int i = 0; i < N; i++)
//    {
//      int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      Brave _brave = new Brave(_line[0], _line[1], _line[2], _line[3], _line[4], _line[5], _line[6]);
//      _braves[i] = _brave;
//    }
//    for (int i = 0; i < K; i++)
//    {
//      string[] _words = Console.ReadLine().Split();
//      int n = int.Parse(_words[0]) - 1;
//      string _event = _words[1];
//      switch (_event)
//      {
//        case "levelup":
//          int _health = int.Parse(_words[2]);
//          int _attack = int.Parse(_words[3]);
//          int _defense = int.Parse(_words[4]);
//          int _speed = int.Parse(_words[5]);
//          int _cleverness = int.Parse(_words[6]);
//          int _fortune = int.Parse(_words[7]);
//          _braves[n].LevelUp(_health, _attack, _defense, _speed, _cleverness, _fortune);
//          break;

//        case "muscle_training":
//          _health = int.Parse(_words[2]);
//          _attack = int.Parse(_words[3]);
//          _braves[n].MuscleTraining(_health, _attack);
//          break;

//        case "running":
//          _defense = int.Parse(_words[2]);
//          _speed = int.Parse(_words[3]);
//          _braves[n].Running(_defense, _speed);
//          break;

//        case "study":
//          _cleverness = int.Parse(_words[2]);
//          _braves[n].Study(_cleverness);
//          break;

//        case "pray":
//          _fortune = int.Parse(_words[2]);
//          _braves[n].Pray(_fortune);
//          break;
//      }
//    }

//    foreach (var _brave in _braves)
//    {
//      Console.WriteLine(_brave.ToFormat());
//    }
//  }
//}

////STEP: 2 RPG
//public class Brave
//{
//  private int level;
//  private int health;
//  private int attack;
//  private int defense;
//  private int speed;
//  private int cleverness;
//  private int fortune;

//  public Brave(int _level, int _health, int _attack, int _defense, int _speed, int _cleverness, int _fortune)
//  {
//    level = _level;
//    health = _health;
//    attack = _attack;
//    defense = _defense;
//    speed = _speed;
//    cleverness = _cleverness;
//    fortune = _fortune;
//  }

//  public void LevelUp(int _health, int _attack, int _defense, int _speed, int _cleverness, int _fortune)
//  {
//    level++;
//    health += _health;
//    attack += _attack;
//    defense += _defense;
//    speed += _speed;
//    cleverness += _cleverness;
//    fortune += _fortune;
//  }

//  public void MuscleTraining(int _health, int _attack)
//  {
//    health += _health;
//    attack += _attack;
//  }

//  public void Running(int _defense, int _speed)
//  {
//    defense += _defense;
//    speed += _speed;
//  }

//  public void Study(int _cleverness) => cleverness += _cleverness;
//  public void Pray(int _fortune) => fortune += _fortune;

//  public string ToFormat()
//  {
//    return $"{level} {health} {attack} {defense} {speed} {cleverness} {fortune}";
//  }
//}