//class Program
//{
//  static void Main()
//  {
//    //自分の得意な言語で
//    //Let's チャレンジ！！
//    /********** Vtuber **********/
//    //STEP: 1 アイドルグループ
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];

//    //SortedSet<string> _members = new SortedSet<string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  _members.Add(Console.ReadLine());
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  switch (_strings[0])
//    //  {
//    //    case "join":
//    //      _members.Add(_strings[1]);
//    //      break;

//    //    case "leave":
//    //      _members.Remove(_strings[1]);
//    //      break;

//    //    case "handshake":
//    //      if (_members.Count == 0) continue;
//    //      Console.WriteLine(string.Join("\n", _members));
//    //      break;
//    //  }
//    //}

//    //STEP: 2 歴史を作る時間
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Dictionary<int, List<string>> history = new Dictionary<int, List<string>>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  Console.ReadLine();
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  int year = int.Parse(_strings[0]);
//    //  string name = _strings[1];
//    //  if (history.ContainsKey(year))
//    //  {
//    //    history[year].Add(name);
//    //  }
//    //  else
//    //  {
//    //    history[year] = new List<string> { name };
//    //  }
//    //}
//    //history = history
//    //  .OrderBy(x => x.Key)
//    //  .ThenBy(x => x.Value.OrderBy(y => y))
//    //  .ToDictionary(x => x.Key, x => x.Value);
//    //foreach (var item in history)
//    //{
//    //  Console.WriteLine(string.Join("\n", item.Value));
//    //}

//    //STEP: 3 銀行
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Dictionary<string, int> numbers = new Dictionary<string, int>();
//    //Dictionary<string, int> balances = new Dictionary<string, int>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string name = _strings[0];
//    //  int number = int.Parse(_strings[1]);
//    //  int balance = int.Parse(_strings[2]);
//    //  numbers.Add(name, number);
//    //  balances.Add(name, balance);
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string name = _strings[0];
//    //  int number = int.Parse(_strings[1]);
//    //  int balance = int.Parse(_strings[2]);
//    //  if (numbers.ContainsKey(name) && numbers[name] == number)
//    //  {
//    //    balances[name] -= balance;
//    //  }
//    //}
//    //foreach (var item in balances)
//    //{
//    //  Console.WriteLine(item.Key + " " + item.Value);
//    //}

//    //STEP: 4 経理
//    //int[] NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
//    //int N = NK[0], K = NK[1];
//    //Dictionary<string, Dictionary<string, int>> receipt = new Dictionary<string, Dictionary<string, int>>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string name = Console.ReadLine();
//    //  receipt.Add(name, new Dictionary<string, int>());
//    //}
//    //for (int i = 0; i < K; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string name = _strings[0];
//    //  string number = _strings[1];
//    //  int money = int.Parse(_strings[2]);
//    //  if (receipt.ContainsKey(name))
//    //  {
//    //    receipt[name].Add(number, money);
//    //  }
//    //}
//    //foreach (var item in receipt)
//    //{
//    //  Console.WriteLine(item.Key);
//    //  foreach (var item2 in item.Value)
//    //  {
//    //    Console.WriteLine($"{item2.Key} {item2.Value}");
//    //  }
//    //  Console.WriteLine("-----");
//    //}

//    //FINAL問題 Vtuber
//    //int N = int.Parse(Console.ReadLine());
//    //Dictionary<string, int> superchats = new Dictionary<string, int>();
//    //List<string> members = new List<string>();
//    //for (int i = 0; i < N; i++)
//    //{
//    //  string[] _strings = Console.ReadLine().Split();
//    //  string name = _strings[0];
//    //  switch (_strings[1])
//    //  {
//    //    case "give":
//    //      if (superchats.ContainsKey(name))
//    //      {
//    //        superchats[name] += int.Parse(_strings[2]);
//    //      }
//    //      else
//    //      {
//    //        superchats.Add(name, int.Parse(_strings[2]));
//    //      }
//    //      break;

//    //    case "join":
//    //      members.Add(name);
//    //      break;
//    //  }
//    //}
//    //superchats = superchats
//    //  .OrderByDescending(x => x.Value)
//    //  .ThenByDescending(x => x.Key)
//    //  .ToDictionary(x => x.Key, x => x.Value);
//    //members = members
//    //  .OrderBy(x => x)
//    //  .ToList();

//    //foreach (var item in superchats)
//    //{
//    //  Console.WriteLine(item.Key);
//    //}
//    //foreach (var item in members)
//    //{
//    //  Console.WriteLine(item);
//    //}
//  }
//}
