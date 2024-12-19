//using System;
//using System.Collections.Generic;

//class Program
//{
//  static void Main()
//  {
//    string S = Console.ReadLine();
//    long[] _counts = new long[26];
//    Stack<long> _stack = new Stack<long>();

//    long _nowk = 1;
//    for (int _i = 0; _i < S.Length; _i++)
//    {
//      char _char = S[_i];
//      if (char.IsDigit(_char))
//      {
//        string _strk = "";
//        while (char.IsDigit(_char))
//        {
//          _strk += _char.ToString();
//          _i++;
//          _char = S[_i];
//        }
//        long _k = long.Parse(_strk);
//        if (_char == '(')
//        {
//          _stack.Push(_k);
//          _nowk *= _k;
//        }
//        else
//        {
//          int _index = _char - 'a';
//          _counts[_index] += _nowk * _k;
//        }
//      }
//      else if (_char == ')')
//      {
//        long _k = _stack.Pop();
//        _nowk /= _k;
//      }
//      else
//      {
//        int _index = _char - 'a';
//        _counts[_index] += _nowk;
//      }
//    }

//    for (int _i = 0; _i < 26; _i++)
//    {
//      Console.WriteLine($"{(char)('a' + _i)} {_counts[_i]}");
//    }
//  }
//}
