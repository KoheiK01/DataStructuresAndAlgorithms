using System;

/// <summary>
/// 開番地法を利用したハッシュテーブルの実装です。
/// ハッシュ関数はKeyの長さを用いる．
/// 再ハッシュは一次ハッシュを用いる．
/// </summary>
/// <typeparam name="T"></typeparam>
public class HashTableOpenAddressing<T>
{
  private const int BUCKET_SIZE = 5;
  private readonly (T Data, bool IsDeleted)[] buckets; // バケットの配列

  public HashTableOpenAddressing()
  {
    // バケットを初期化する
    buckets = new (T Data, bool IsDeleted)[BUCKET_SIZE];
  }

  /// <summary>
  /// ハッシュ関数を用いてバケット番号（インデックス）を返す
  /// </summary>
  /// <param name="_data"></param>
  /// <param name="_count"></param>
  /// <returns></returns>
  private int GetIndex(T _data, int _count)
  {
    return (_data.ToString().Length + _count) % BUCKET_SIZE;
  }

  /// <summary>
  /// ハッシュに要素が存在するか確認する
  /// 再ハッシュは一次ハッシュを用いる．
  /// </summary>
  /// <param name="_data"></param>
  /// <returns></returns>
  public bool Member(T _data)
  {
    int _count = 0;//再ハッシュ回数カウンタ

    while (_count < BUCKET_SIZE)
    {
      //ハッシュ関数を適用する．
      int _index = GetIndex(_data, _count);

      //要素が重複している．
      if (buckets[_index].Data != null && buckets[_index].Data.Equals(_data))
      {
        return true;
      }

      //他のものが入っているか、deletedのときは再ハッシュ（一次ハッシュ）
      _count++;
    }

    //最後まで行った=要素の重複は存在しなかった．
    return false;
  }

  /// <summary>
  /// ハッシュに要素を追加する
  /// </summary>
  /// <param name="_data"></param>
  public void Insert(T _data)
  {
    //重複チェック(deletedの先も見る)
    if (Member(_data)) return;

    int _count = 0;//再ハッシュ回数カウンタ

    while (_count < BUCKET_SIZE)
    {
      //ハッシュ関数を適用する．
      int _index = GetIndex(_data, _count);

      //空番地を発見したならば要素を挿入する
      if (buckets[_index].Data == null || buckets[_index].IsDeleted)
      {
        buckets[_index] = (_data, false);
        return;
      }

      //他のものが入っているか、deletedのときは再ハッシュ（一次ハッシュ）
      _count++;
    }

    throw new InvalidOperationException("Hash table is full");
  }

  /// <summary>
  /// ハッシュから要素を削除する
  /// </summary>
  /// <param name="_data"></param>
  public void Delete(T _data)
  {
    int _count = 0;//再ハッシュ回数カウンタ

    while (_count < BUCKET_SIZE)
    {
      //ハッシュ関数を適用する．
      int _index = GetIndex(_data, _count);

      //削除したい要素が見つかったならば削除する．
      if (buckets[_index].Data != null && buckets[_index].Data.Equals(_data))
      {
        buckets[_index] = (default, true); //削除マーカーを設定
        return;
      }

      //他のものが入っているか、deletedのときは再ハッシュ（一次ハッシュ）
      _count++;
    }
  }
}

//public class Example
//{
//  public static void Main()
//  {
//    HashTableOpenAddressing<string> _hashTable = new HashTableOpenAddressing<string>();
//    _hashTable.Insert("dog");
//    _hashTable.Insert("bird");
//    _hashTable.Insert("cat");
//    _hashTable.Delete("dog");
//    _hashTable.Insert("rat");
//    _hashTable.Delete("cat");
//  }
//}
