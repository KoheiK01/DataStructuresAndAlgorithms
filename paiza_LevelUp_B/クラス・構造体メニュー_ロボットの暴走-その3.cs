//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** ロボットの暴走 **********/
//    //STEP: 3 格闘ゲーム
//    int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    int N = NK[0], K = NK[1];
//    Player[] _players = new Player[N];
//    for (int i = 0; i < N; i++)
//    {
//      int[] _line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      Player _player = new Player(_line[0], _line[1], _line[2], _line[3], _line[4], _line[5], _line[6]);
//      _players[i] = _player;
//    }

//    for (int i = 0; i < K; i++)
//    {
//      int[] _event = Console.ReadLine().Split().Select(int.Parse).ToArray();
//      Player _player1 = _players[_event[0] - 1];
//      int _player1Event = _event[1] - 1;
//      int _hp1 = _player1.HP;
//      int _attack1 = _player1.Attacks[_player1Event];
//      int _frame1 = _player1.Frames[_player1Event];
//      bool _isEnhance1 = _player1.IsEnhance(_player1Event);
//      Player _player2 = _players[_event[2] - 1];
//      int _player2Event = _event[3] - 1;
//      int _hp2 = _player2.HP;
//      int _attack2 = _player2.Attacks[_player2Event];
//      int _frame2 = _player2.Frames[_player2Event];
//      bool _isEnhance2 = _player2.IsEnhance(_player2Event);


//      if (_hp1 <= 0 || _hp2 <= 0)
//        continue;

//      if (_isEnhance1 && _isEnhance2)
//      {
//        _player1.Enhance();
//        _player2.Enhance();
//      }
//      else if (_isEnhance1)
//      {
//        _player1.Enhance();
//        _player1.Damage(_attack2);
//      }
//      else if (_isEnhance2)
//      {
//        _player2.Enhance();
//        _player2.Damage(_attack1);
//      }
//      else
//      {
//        if (_frame1 < _frame2)
//        {
//          _player2.Damage(_attack1);
//        }
//        else if (_frame2 < _frame1)
//        {
//          _player1.Damage(_attack2);
//        }
//      }
//    }

//    Console.WriteLine(_players.Count(_player => _player.HP > 0));
//  }
//}

////STEP: 3 格闘ゲーム
//public class Player
//{
//  public int HP;
//  public int[] Frames;
//  public int[] Attacks;

//  public Player(int _hp, int _frame1, int _attack1, int _frame2, int _attack2, int _frame3, int _attack3)
//  {
//    HP = _hp;
//    Frames = new int[3] { _frame1, _frame2, _frame3 };
//    Attacks = new int[3] { _attack1, _attack2, _attack3 };
//  }

//  public bool IsEnhance(int _event) => Frames[_event] == 0;

//  public void Enhance()
//  {
//    for (int i = 0; i < 3; i++)
//    {
//      if (Frames[i] != 0)
//      {
//        Frames[i] = Math.Max(1, Frames[i] - 3);
//        Attacks[i] += 5;
//      }
//    }
//  }

//  public void Damage(int _damege) => HP -= _damege;
//}