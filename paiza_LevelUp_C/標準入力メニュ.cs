//using System;
//using System.Linq;
//using System.Runtime.InteropServices;

//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let's チャレンジ！！
//    /********** 【行入力】1,000 行の入力 **********/
//    //1～5問目
//    //int N = 1000;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Console.ReadLine());
//    //}
//    /********** 【半角スペース区切りでの文字列の分割】5 つの文字列の半角スペース区切りでの分割 **********/
//    //1～3問目
//    //string[] _strings = { "one", "two", "three", "four", "five" };
//    //for (int i = 0; i < _strings.Length; i++)
//    //{
//    //  Console.WriteLine(_strings[i]);
//    //}
//    /********** 【半角スペース区切りの入力】半角スペース区切りの 1,000 個の入力 **********/
//    //1～5問目
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //for (int i = 0; i < _strings.Length; i++)
//    //{
//    //  Console.WriteLine(_strings[i]);
//    //}
//    /********** 【整数の行入力】1,000行の整数の入力 **********/
//    //1～5問目
//    //int N = 1000;
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Console.ReadLine());
//    //}
//    /********** 【整数の半角スペース区切りの入力】1,000個の整数の半角スペース区切りの入力 **********/
//    //1～5問目
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //for (int i = 0; i < _strings.Length; i++)
//    //{
//    //  Console.WriteLine(_strings[i]);
//    //}
//    /********** 【N 個の整数の入力】1 行目で与えられる N 個の整数の入力 (large) **********/
//    //1～5問目
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //int N = int.Parse(_strings[0]);
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(_strings[i + 1]);
//    //}
//    /********** 【N個の文字列の入力】1 行目で与えられる N 個の文字列の入力 (large) **********/
//    //1問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Console.ReadLine());
//    //}
//    //2～5問目
//    //int N = int.Parse(Console.ReadLine());
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //int N = int.Parse(_strings[0]);
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(_strings[i+1]);
//    //}
//    /********** 1 行目で与えられる N 個の実数の入力 (large) **********/
//    //1問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Console.ReadLine());
//    //}
//    //2～5問目
//    //int N = int.Parse(Console.ReadLine());
//    //string[] _strings = Console.ReadLine().Split(' ');
//    //int N = int.Parse(_strings[0]);
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(_strings[i + 1]);
//    //}
//    /********** 【組になったデータの入力】文字列と整数の組からの選択 **********/
//    //1～2・4問目
//    //int N = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(Console.ReadLine());
//    //}
//    //3・5問目
//    //int N = int.Parse(Console.ReadLine());
//    //string[] _strings = new string[N];
//    //for (int i = 0; i < N; i++)
//    //{
//    //  _strings[i] = Console.ReadLine();
//    //}
//    //Console.WriteLine(_strings[7]);
//    /********** 【N 行 M 列のデータの入力】行ごとに要素数の異なる整数列の入力 **********/
//    //1～5問目
//    //int height = Console.ReadLine().Split(' ').Select(int.Parse).ToArray()[0];
//    //int height = int.Parse(Console.ReadLine());
//    //int height = 3;
//    //int width = int.Parse(Console.ReadLine());
//    //for (int i = 0; i < height; i++)
//    //{
//    //  var words = Console.ReadLine().Split(' ').ToArray();
//    //  Console.WriteLine(string.Join(" ",words.Skip(1)));
//    //}
//  }
//}