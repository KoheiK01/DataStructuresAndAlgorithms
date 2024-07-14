//using System;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using System.Text.RegularExpressions;

//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    //1問目
//    //Console.WriteLine("paiza");
//    //2問目
//    //Console.WriteLine(Console.ReadLine());
//    //3問目
//    //string S = Console.ReadLine();
//    //int index = int.Parse(Console.ReadLine()) - 1;
//    //Console.WriteLine(S[index]);
//    //4問目
//    //string S = Console.ReadLine();
//    //Console.WriteLine(S == "paiza" ? "YES" : "NO");
//    //5問目
//    //string S=Console.ReadLine();
//    //Console.WriteLine(S.Length);
//    //6問目
//    //string S = Console.ReadLine();
//    //string T = Console.ReadLine();
//    //Console.WriteLine(S.IndexOf(T) + 1);
//    //7問目
//    //int N = int.Parse(Console.ReadLine());
//    //string ans = "";
//    //for (int _index = 0; _index < N; _index++)
//    //{
//    //  ans += Console.ReadLine();
//    //}
//    //Console.WriteLine(ans);
//    //8問目
//    //string S = Console.ReadLine();
//    //int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//    //int start = line[0] - 1, count = line[1] - start;
//    //Console.WriteLine(S.Substring(start,count));
//    //9問目
//    //string S = Console.ReadLine();
//    //string T = Console.ReadLine();
//    //int N = int.Parse(Console.ReadLine());
//    //Console.WriteLine(S.Insert(N, T));
//    //10問目
//    //string S = Console.ReadLine();
//    //string[] sLine = Console.ReadLine().Split();
//    //int index = int.Parse(sLine[0]) - 1;
//    //string c = sLine[1];
//    //S = S.Substring(0, index) + c + S.Substring(index + 1);
//    //Console.WriteLine(S);
//    //11問目
//    //int N = int.Parse(Console.ReadLine());
//    //Console.WriteLine(N - 813);
//    //12問目
//    //int X = int.Parse(Console.ReadLine());
//    //int Y = int.Parse(Console.ReadLine());
//    //int n = int.Parse(Console.ReadLine());
//    //Console.WriteLine((X + Y).ToString()[n-1]); 
//    //13～14問目
//    //string S = Console.ReadLine();
//    //Console.WriteLine(S.ToLower());
//    //Console.WriteLine(S.ToUpper());
//    //15問目
//    //string S = Console.ReadLine();
//    //string ans = "";
//    //for (int _index = 0; _index < S.Length; _index++)
//    //{
//    //  if (char.IsUpper(S[_index]))
//    //  {
//    //    ans += S[_index].ToString().ToLower();
//    //  }
//    //  else
//    //  {
//    //    ans += S[_index].ToString().ToUpper();
//    //  }
//    //}
//    //Console.WriteLine(ans);
//    //16問目
//    //string S = Console.ReadLine();
//    //string T = Console.ReadLine();
//    //if (S.Contains(T)) { Console.WriteLine("YES"); }
//    //else { Console.WriteLine("NO"); }
//    //17問目
//    //string S = Console.ReadLine();
//    //S = new string(S.Reverse().ToArray());
//    //Console.WriteLine(S);
//    //18問目
//    //string S = Console.ReadLine();
//    //string T = new string(S.Reverse().ToArray());
//    //if (S == T) { Console.WriteLine("YES"); }
//    //else { Console.WriteLine("NO"); }
//    //19～21問目
//    //string[] fLine = Console.ReadLine().Split(',');
//    //string[] fLine = Console.ReadLine().Split(new char[] { '/', ':' });
//    //string[] fLine = Console.ReadLine().Split(new char[] { '/', ':', ' ' });
//    //Console.WriteLine(string.Join("\n", fLine));
//    //22問目
//    //string S = Console.ReadLine();
//    //bool beNum = true;
//    //foreach (var c in S)
//    //{
//    //  if(!int.TryParse(c.ToString(),out int tmp))
//    //  {
//    //    beNum = false;
//    //    break;
//    //  }
//    //}
//    //if (beNum) { Console.WriteLine("YES"); }
//    //else { Console.WriteLine("NO"); }
//    //23問目
//    //char[] fLine = Console.ReadLine().Distinct().ToArray();
//    //Console.WriteLine(string.Join("",fLine));
//    //24問目
//    //int N = int.Parse(Console.ReadLine());
//    //int Q = int.Parse(Console.ReadLine());
//    //char[] ans = new char[N];
//    //for (int index = 0; index < Q; index++)
//    //{
//    //  var line = Console.ReadLine().Split();
//    //  int index = int.Parse(line[0]) - 1;
//    //  ans[index] = line[1][0];
//    //}
//    //char c = Console.ReadLine()[0];
//    //for (int index = 0; index < N; index++)
//    //{
//    //  ans[index] = ans[index] == '\0' ? c : ans[index];
//    //}
//    //Console.WriteLine(string.Join("", ans));
//    //25問目(重要!!!)
//    //string S = Console.ReadLine();
//    //if (S.Contains('.'))
//    //{
//    //  int index = S.IndexOf('.');
//    //  S = S.Substring(0, index + 1) + S.Substring(index + 1).Replace(".", "");
//    //  S = Regex.Replace(S, "$0+", "");
//    //  while (S.Last() == '0')
//    //  {
//    //    S = S.Trim('0');
//    //    if (S.Last() == '.')
//    //    {
//    //      S = S.Replace(".", "");
//    //      break;
//    //    }
//    //  }
//    //}
//    //S = Regex.Replace(S, "^0+", "");
//    //if (S[0] == '.')
//    //{
//    //  S = S.Insert(0, "0");
//    //}
//    //Console.WriteLine(S);
//    //26～27問目(注意!!!)
//    //string S = Console.ReadLine();
//    //S += ".";
//    //int ans = 0;
//    //char operand = '+';
//    //string strNum = "";

//    //foreach (var c in S)
//    //{
//    //  if (int.TryParse(c.ToString(), out int tmp))
//    //  {
//    //    strNum += tmp;
//    //  }
//    //  else
//    //  {
//    //    ans = CalOperand(operand, ans, int.Parse(strNum));
//    //    strNum = "";
//    //    operand = c;
//    //  }
//    //}
//    //Console.WriteLine(ans);
//    //28～29問目
//    //string S = Console.ReadLine();
//    //string T = Console.ReadLine();
//    //string ans = "";
//    //int carry = 0;
//    //for (int i = S.Length - 1; i >= 0; i--)
//    //{
//    //  int product = int.Parse(S[i].ToString()) + int.Parse(T[i].ToString()) + carry;
//    //  carry = product / 10;
//    //  ans += product % 10;
//    //}
//    //ans += carry == 1 ? "1" : "";
//    //ans = new string(ans.Reverse().ToArray());
//    //Console.WriteLine(ans);
//    //30問目
//    //string S = Console.ReadLine();
//    //int T = int.Parse(Console.ReadLine());
//    //if (T == 0) { Console.WriteLine(0); return; }
//    //string ans = "";
//    //int carry = 0;
//    //for (int i = S.Length - 1; i >= 0; i--)
//    //{
//    //  int product = int.Parse(S[i].ToString()) * T + carry;
//    //  carry = product / 10;
//    //  ans += product % 10;
//    //}
//    //ans += carry == 0 ? "" : carry.ToString();
//    //ans = new string(ans.Reverse().ToArray());
//    //Console.WriteLine(ans);
//  }

//  //public static int CalOperand(char operand, int ans, int num)
//  //{
//  //  return operand == '+' ? ans + num : ans - num;
//  //}
//}