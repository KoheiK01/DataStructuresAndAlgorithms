using System;
class Program
{
  static void Main()
  {
    // 自分の得意な言語で
    // Let's チャレンジ！！
    var words = Console.ReadLine().Split();
    int H = int.Parse(words[0]);
    int W = int.Parse(words[1]);
    char[,] map = new char[H, W];

    for (int h = 0; h < H; h++)
    {
      string line = Console.ReadLine();
      for (int w = 0; w < W; w++)
      {
        map[h, w] = line[w];
      }
    }

    int count = 0;
    for (int h = 1; h < H - 1; h++)
    {
      for (int w = 1; w < W - 1; w++)
      {
        if (map[h, w] == '.' &&
          map[h - 1, w - 1] == '#' && map[h, w - 1] == '#' && map[h + 1, w - 1] == '#' &&
          map[h - 1, w] == '#' && map[h + 1, w] == '#' &&
          map[h - 1, w + 1] == '#' && map[h, w + 1] == '#' && map[h + 1, w + 1] == '#')
        {
          count++;
        }
      }
    }
    Console.WriteLine(count);
  }
}