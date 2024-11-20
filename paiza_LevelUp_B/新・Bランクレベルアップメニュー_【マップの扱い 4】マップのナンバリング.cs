//using System;
//using System.Linq;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 【マップの扱い 4】マップのナンバリング **********/
//    //【マップの扱い 1】マップの書き換え・1 マス
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = firstLine[0], W = firstLine[1];
//    //char[][] map = new char[H][];
//    //for (int h = 0; h < H; h++)
//    //{
//    //  map[h] = Console.ReadLine().ToCharArray();
//    //}
//    //int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int y = line[0], x = line[1];
//    //map[y][x] = map[y][x] == '.' ? '#' : '.';
//    //for (int h = 0; h < H; h++)
//    //{
//    //  Console.WriteLine(string.Join("", map[h]));
//    //}

//    //【マップの扱い 2】マップの書き換え・縦横
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = firstLine[0], W = firstLine[1];
//    //char[][] map = new char[H][];
//    //for (int h = 0; h < H; h++)
//    //{
//    //  map[h] = Console.ReadLine().ToCharArray();
//    //}
//    //int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int y = line[0], x = line[1];
//    //int[] dy = { 0, -1, 1, 0, 0 };
//    //int[] dx = { 0, 0, 0, -1, 1 };
//    //for (int i = 0; i < 5; i++)
//    //{
//    //  int ny = y + dy[i];
//    //  int nx = x + dx[i];
//    //  if (ny >= 0 && ny < H && nx >= 0 && nx < W)
//    //  {
//    //    map[ny][nx] = map[ny][nx] == '.' ? '#' : '.';
//    //  }
//    //}
//    //for (int h = 0; h < H; h++)
//    //{
//    //  Console.WriteLine(string.Join("", map[h]));
//    //}

//    //【マップの扱い 3】マップの判定・縦横斜め
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = firstLine[0], W = firstLine[1];
//    //char[][] map = new char[H][];
//    //for (int h = 0; h < H; h++)
//    //{
//    //  map[h] = Console.ReadLine().ToCharArray();
//    //}
//    //int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int y = line[0], x = line[1];
//    //int[] dy = { -1, 1, 0, 0, -1, -1, 1, 1 };
//    //int[] dx = { 0, 0, -1, 1, -1, 1, -1, 1 };
//    //for (int i = 0; i < 8; i++)
//    //{
//    //  int ny = y + dy[i];
//    //  int nx = x + dx[i];
//    //  while (ny >= 0 && ny < H && nx >= 0 && nx < W)
//    //  {
//    //    map[ny][nx] = map[ny][nx] == '.' ? '#' : '.';
//    //    ny += dy[i];
//    //    nx += dx[i];
//    //  }
//    //}
//    //map[y][x] = map[y][x] == '.' ? '#' : '.';
//    //for (int h = 0; h < H; h++)
//    //{
//    //  Console.WriteLine(string.Join("", map[h]));
//    //}

//    //【マップの扱い 4】マップのナンバリング
//    //int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int H = firstLine[0], W = firstLine[1], D = firstLine[2] - 1;
//    //int[] dy = { -1, 0, 1, 1 }, dx = { 1, 1, 0, -1 };
//    //int[,] map = new int[H, W];
//    //int number = 1;
//    //int starty = 0, startx = 0;
//    //while (number <= H * W)
//    //{
//    //  int ny = starty, nx = startx;
//    //  while (ny >= 0 && ny < H && nx >= 0 && nx < W)
//    //  {
//    //    map[ny, nx] = number++;
//    //    ny += dy[D];
//    //    nx += dx[D];
//    //  }

//    //  if (D == 0 || D == 1)
//    //  {
//    //    if (startx + 1 < W) startx++;
//    //    else starty++;
//    //  }
//    //  else
//    //  {
//    //    if (starty + 1 < H) starty++;
//    //    else startx++;
//    //  }
//    //}
//    //for (int h = 0; h < H; h++)
//    //{
//    //  for (int w = 0; w < W; w++)
//    //  {
//    //    if (w == W - 1) { Console.WriteLine(map[h, w]); }
//    //    else { Console.Write(map[h, w] + " "); }
//    //  }
//    //}
//  }
//}
