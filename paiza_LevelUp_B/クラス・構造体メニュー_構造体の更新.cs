//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** 構造体の作成 **********/
//    //STEP: 1 構造体の作成
//    //STEP: 2 構造体の検索
//    //STEP: 3 構造体の整列
//    //FINAL問題 構造体の更新
//    //int N = int.Parse(Console.ReadLine());
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //List<User> users = new List<User>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split();
//    //  User user = new User()
//    //  {
//    //    nickname = words[0],
//    //    old = int.Parse(words[1]),
//    //    birth = words[2],
//    //    state = words[3],
//    //  };
//    //  users.Add(user);
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] words = Console.ReadLine().Split();
//    //  int _age = int.Parse(words[0]) - 1;
//    //  string newname = words[1];
//    //  users[_age] = users[_age].ChangeName(newname);
//    //}
//    //users = users.OrderBy(x => x.old).ToList();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.WriteLine(users[i].ToFormat());
//    //}
//    //int K = int.Parse(Console.ReadLine());
//    //User ansUser = users.Where(user => user.old == K).First();
//    //Console.WriteLine(ansUser.nickname);
//  }
//}

////STEP: 1 構造体の作成
////STEP: 2 構造体の検索
////STEP: 3 構造体の整列
////FINAL問題 構造体の更新
////public struct User
////{
////  public string nickname;
////  public int old;
////  public string birth;
////  public string state;

////  public User ChangeName(string newname)
////  {
////    nickname = newname;
////    return this;
////  }

////  public string ToFormat()
////  {
////    string format = "User{";
////    format += $"\n{nameof(nickname)} : {nickname}";
////    format += $"\n{nameof(old)} : {old}";
////    format += $"\n{nameof(birth)} : {birth}";
////    format += $"\n{nameof(state)} : {state}";
////    format += "\n}";
////    return format;
////  }

////  public string ToFormat()
////  {
////    return $"{nickname} {old} {birth} {state}";
////  }
////}

