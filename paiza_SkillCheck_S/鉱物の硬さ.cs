using System;
using System.Collections.Generic;

class Program
{
  static void Main()
  {
    var _line = Console.ReadLine().Split();
    int N = int.Parse(_line[0]);
    int M = int.Parse(_line[1]);

    List<int>[] _winMinerals = new List<int>[N + 1];
    for (int i = 1; i <= N; i++)
    {
      _winMinerals[i] = new List<int>();
    }
    int[] _loseCount = new int[N + 1];

    for (int i = 0; i < M; i++)
    {
      _line = Console.ReadLine().Split();
      int _winner = int.Parse(_line[0]);
      int _loser = int.Parse(_line[1]);
      _winMinerals[_winner].Add(_loser);
      _loseCount[_loser]++;
    }

    Queue<int> _tmpQueue = new Queue<int>();
    for (int i = 1; i <= N; i++)
    {
      if (_loseCount[i] == 0)
      {
        _tmpQueue.Enqueue(i);
      }
    }

    List<int> _result = new List<int>();

    while (_tmpQueue.Count > 0)
    {
      if (_tmpQueue.Count > 1)
      {
        Console.WriteLine(-1);
        return;
      }

      int _currentTop = _tmpQueue.Dequeue();
      _result.Add(_currentTop);

      foreach (var _mineral in _winMinerals[_currentTop])
      {
        _loseCount[_mineral]--;
        if (_loseCount[_mineral] == 0)
        {
          _tmpQueue.Enqueue(_mineral);
        }
      }
    }

    if (_result.Count != N)
    {
      Console.WriteLine(-1);
    }
    else
    {
      Console.WriteLine(string.Join(" ", _result));
    }
  }
}
