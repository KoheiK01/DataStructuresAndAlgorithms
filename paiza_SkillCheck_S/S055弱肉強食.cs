using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
  static void Main()
  {
    int[] _firstLine = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
    int H = _firstLine[0], W = _firstLine[1];
    char[][] _grid = ReadGrid(H);
    int N = int.Parse(Console.ReadLine());
    Dictionary<char, List<char>> _children = ReadChildren(N);
  }

  private static char[][] ReadGrid(int H)
  {
    char[][] _grid = new char[H][];
    for (int _y = 0; _y < H; _y++)
    {
      _grid[_y] = Console.ReadLine().Split().Select(char.Parse).ToArray();
    }
    return _grid;
  }

  private static Dictionary<char, List<char>> ReadChildren(int N)
  {
    Dictionary<char, List<char>> _children = new Dictionary<char, List<char>>();
    for (int _i = 0; _i < N; _i++)
    {
      char[] _relation = Console.ReadLine().Split().Select(char.Parse).ToArray();
      char _child = _relation[0];
      char _parent = _relation[1];
      if (_children.ContainsKey(_parent))
      {
        _children[_parent].Add(_child);
      }
      else
      {
        _children.Add(_parent, new List<char> { _child });
      }
    }

    return _children;
  }
}
