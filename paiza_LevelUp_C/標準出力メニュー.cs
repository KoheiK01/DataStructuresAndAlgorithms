//using System;
//using System.Linq;
//using System.Runtime.InteropServices;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 【改行あり出力】1,000 行の出力 **********/
//    //1問目
//    //int height = 813;
//    //Console.WriteLine(height);
//    //2問目
//    //Console.WriteLine(8);
//    //Console.WriteLine(13);
//    //3問目
//    //Console.WriteLine(8); 
//    //Console.WriteLine(1);
//    //Console.WriteLine(3);
//    //4問目
//    //int[] _strings = { 813, 1, 2, 923874, 23648, 782356, 3256, 2342, 24324, 112 };
//    //Console.WriteLine(string.Join("\n", _strings));
//    //5問目
//    //for (int i = 1; i <= 1000; i++)
//    //{
//    //  Console.WriteLine(i);
//    //}
//    /********** 【半角スペース区切りの出力】1,000 個の数値を出力 **********/
//    //1問目
//    //int[] _ints = { 1, 1 };
//    //2問目
//    //int[] _ints = { 8, 1, 3 };
//    //3～5問目
//    //int height = 1000;
//    //int[] ints = Enumerable.Range(1, height).ToArray();
//    //Console.WriteLine(string.Join(" ", ints));
//    /********** 【文字列の出力】入力された 10 個の文字列を出力 **********/
//    //1問目
//    //string str = "paiza";
//    //2問目
//    //string[] strs = new string[] { "paiza", "learning" };
//    //3～4問目
//    //4問目
//    //int height = 10;
//    //string[] strs = new string[height];
//    //for (int i = 0; i < height; i++)
//    //{
//    //  strs[i] = Console.ReadLine();
//    //}
//    //5問目
//    //string[] strs = Console.ReadLine().Split(' ');
//    //Console.WriteLine(string.Join("\n", strs));
//    /********** 【n 行の出力】1,000 行以内の出力 **********/
//    //1～4問目
//    //int height = int.Parse(Console.ReadLine());
//    //int[] ints = Enumerable.Range(1, height).ToArray();
//    //Console.WriteLine(string.Join("\n", ints));
//    /********** 【特定の文字で区切り 1 行で出力】大きな数値を 3 けたごとにカンマ区切りで出力 2 **********/
//    //1問目
//    //string[] _strings = Console.ReadLine().Split();
//    //2問目
//    //int height = 3;
//    //string[] _strings = new string[height];
//    //for (int i = 0; i < height; i++)
//    //{
//    //  _strings[i] = Console.ReadLine();
//    //}
//    //3～4問目
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //5問目
//    //int height = 10;
//    //string[] _strings = new string[height];
//    //for(int i = 0; i < height; i++)
//    //{
//    //  _strings[i] =Console.ReadLine();
//    //}
//    //6～7問目
//    //string _string = Console.ReadLine();
//    //int height = (int)Math.Ceiling((double)_string.Length / 3);
//    //string[] _strings = new string[height];
//    //for (int i = _string.Length - 1; i >= 0; i -= 3)
//    //{
//    //  int _startIndex = i - 2;
//    //  int _count = 3;
//    //  if (_startIndex < 0)
//    //  {
//    //    _startIndex = 0;
//    //    _count = i + 1;
//    //  }
//    //  _strings[i / 3] = _string.Substring(_startIndex, _count);
//    //}
//    //Console.WriteLine(string.Join(",", _strings));
//    /********** 【n * n の 2 次元配列の表示】height * height の九九表の出力 **********/
//    //1～4問目
//    //int height = int.Parse(Console.ReadLine());
//    //int[][] ququ = new int[height][];
//    //for (int i = 0; i < height; i++)
//    //{
//    //  ququ[i] = new int[height];
//    //  for (int j = 0; j < height; j++)
//    //  {
//    //    ququ[i][j] = (i + 1) * (j + 1);
//    //  }
//    //}
//    //for (int i = 0; i < height; i++)
//    //{
//    //  Console.WriteLine(string.Join(" ", ququ[i]));
//    //}
//    /********** 【行によって長さが違う二次元配列の表示】すべての行の長さと値が不定な 2 次元配列の出力 **********/
//    //1問目
//    //int N = int.Parse(Console.ReadLine());
//    //int height = 2;
//    //int[] wides = new int[height];
//    //int[][] _ints = new int[height][];
//    //for (int i = 0; i < height; i++)
//    //{
//    //  wides[i] = N / height;
//    //}
//    //for (int i = 0; i < height; i++)
//    //{
//    //  _ints[i] = new int[wides[i]];
//    //  for (int j = 0; j < wides[i]; j++)
//    //  {
//    //    _ints[i][j] = i * N / 2 + j + 1;
//    //  }
//    //}
//    //2～5問目
//    //int height = int.Parse(Console.ReadLine());
//    //int[] wides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int[][] _ints = new int[height][];
//    //for (int i = 0; i < height; i++)
//    //{
//    //  _ints[i] = new int[wides[i]];
//    //  for (int j = 0; j < wides[i]; j++)
//    //  {
//    //    _ints[i][j] = j + 1;
//    //  }
//    //}
//    //6問目
//    //var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = line[0];
//    //int height = line[1];
//    //int[] As = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[] wides = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int[][] _ints = new int[height][];
//    //int index = 0;
//    //for (int i = 0; i < height; i++)
//    //{
//    //  _ints[i] = new int[wides[i]];
//    //  for (int j = 0; j < wides[i]; j++)
//    //  {
//    //    _ints[i][j] = As[index];
//    //    index++;
//    //  }
//    //}
//    //for (int i = 0; i < height; i++)
//    //{
//    //  Console.WriteLine(string.Join(" ", _ints[i]));
//    //}
//    /********** 【実数をフォーマット指定して出力】複数の実数を出力 **********/
//    //1～2問目
//    //string N = Console.ReadLine();
//    //Console.WriteLine(N);
//    //3～5問目
//    //int Q = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < Q; i++)
//    //{
//    //  var line = Console.ReadLine().Split().ToArray();
//    //  double N = double.Parse(line[0]);
//    //  int M = int.Parse(line[1]);
//    //  Console.WriteLine(N.ToString("f" + M));
//    //}
//    /********** 【出力幅を指定して出力】height 個の数値を height けた半角スペース埋めで出力 **********/
//    //1～2・4問目
//    //var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = line[0];
//    //int M = line[1];
//    //Console.WriteLine(N.ToString().PadLeft(M, ' '));
//    //3・5問目
//    //var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = line[0];
//    //int M = line[1];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  int a = int.Parse(Console.ReadLine());
//    //  Console.WriteLine(a.ToString().PadLeft(M, ' '));
//    //}
//    /********** 【出力形式を指定して出力】ペアの数値の入った表を罫線入りで出力 2 **********/
//    //1問目
//    //int N = 2;
//    //string[] _strings = new string[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  _strings[i] = Console.ReadLine();
//    //}
//    //Console.WriteLine(_strings[0] + " + " + _strings[1] + " = " + string.Join("", _strings));
//    //2問目
//    //var fLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //string result = string.Join(", ", Enumerable.Repeat($"({fLine[1]}, {fLine[2]})", fLine[0]));
//    //Console.WriteLine(result);
//    //3問目
//    //var fLine = Console.ReadLine().Split();
//    //int h = int.Parse(fLine[0]);
//    //int w = int.Parse(fLine[1]);
//    //string a = fLine[2].PadLeft(9, ' ');
//    //string b = fLine[3].PadLeft(9, ' ');
//    //string line = string.Join(" | ", Enumerable.Repeat($"({a}, {b})", w));
//    //string separation = string.Join("", Enumerable.Repeat("=", line.Length));
//    //string result = string.Join($"\n{separation}\n", Enumerable.Repeat($"{line}", h));
//    //Console.WriteLine(result);
//  }
//}