//using System;
//using System.Linq;
//class Program
//{
//  static void Main()
//  {
//    // 自分の得意な言語で
//    // Let'strNum チャレンジ！！
//    int[] toNums = new int[10]
//    {
//      0,1,-1,-1,-1,-1,9,-1,8,6
//    };

//    var words = Console.ReadLine().Split(' ');
//    int a = int.Parse(words[0]);
//    int b = int.Parse(words[1]);

//    int ans = 0;
//    for (int i = a; i <= b; i++)
//    {
//      string strNum = i.ToString();
//      if (strNum.Last() == '0')
//      {
//        continue;
//      }
//      string newStrNum = "";
//      for (int j = strNum.Length - 1; j >= 0; j--)
//      {
//        int index = int.Parse(strNum[j].ToString());
//        if (toNums[index] == -1)
//        {
//          break;
//        }
//        else
//        {
//          newStrNum += toNums[index].ToString();
//        }
//        if (j == 0 && newStrNum == strNum)
//        {
//          ans++;
//        }
//      }
//    }
//    Console.WriteLine(ans);
//  }
//}