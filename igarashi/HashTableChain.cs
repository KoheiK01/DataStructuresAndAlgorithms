using System;
using System.Collections.Generic;

/// <summary>
/// チェイン法を利用したハッシュテーブルの実装です。
/// ハッシュ関数はKeyの長さを用いる．
/// </summary>
/// <typeparam name="T"></typeparam>
public class HashTableChain<T>
{
  private const int BUCKET_SIZE = 5;
  private readonly List<T>[] buckets; // バケットごとのリスト

  public HashTableChain()
  {
    // リストを初期化する．
    buckets = new List<T>[BUCKET_SIZE];
    for (int _i = 0; _i < buckets.Length; _i++)
    {
      buckets[_i] = new List<T>();
    }
  }

  /// <summary>
  /// ハッシュ関数を用いてバケット番号（インデックス）を返す．
  /// ハッシュ関数はKeyの長さを用いる．
  /// </summary>
  /// <param name="_data"></param>
  /// <returns></returns>
  private int GetIndex(T _data)
  {
    return _data.ToString().Length % BUCKET_SIZE;
  }

  /// <summary>
  /// ハッシュに要素を追加する．
  /// </summary>
  /// <param name="_data"></param>
  public void Insert(T _data)
  {
    int _index = GetIndex(_data);
    buckets[_index].Add(_data);
  }

  /// <summary>
  /// ハッシュから要素を削除する
  /// </summary>
  /// <param name="_data"></param>
  public void Delete(T _data)
  {
    int _index = GetIndex(_data);
    List<T> _bucketList = buckets[_index];
    for (int _i = 0; _i < _bucketList.Count; _i++)
    {
      if (_bucketList[_i].Equals(_data))
      {
        _bucketList.RemoveAt(_i);
        break; // 要素を見つけて削除したらループを終了
      }
    }
  }
}

//public class Example
//{
//  public static void Main()
//  {
//    HashTableChain<string> _hashTable = new HashTableChain<string>();
//    _hashTable.Insert("dog");
//    _hashTable.Insert("bird");
//    _hashTable.Insert("cat");
//    _hashTable.Delete("dog");
//    _hashTable.Insert("rat");
//  }
//}
