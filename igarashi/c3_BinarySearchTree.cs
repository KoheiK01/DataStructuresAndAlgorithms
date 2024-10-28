using System;

/// <summary>
/// 二分探索木を実装します．
/// ヒープではその構造を使用して配列で扱えます．
/// 二分探索木では一般にノードクラスを定義します．
/// </summary>
/// <typeparam name="T"></typeparam>
public class Node<T> where T : IComparable<T>
{
  public T Data;
  public Node<T> Left;
  public Node<T> Right;

  public Node(T _data)
  {
    Data = _data;
    Left = null;
    Right = null;
  }
}

/// <summary>
/// 探索木の実装クラスです．
/// </summary>
/// <typeparam name="T"></typeparam>
public class BinarySearchTree<T> where T : IComparable<T>
{
  public Node<T> Root;

  public BinarySearchTree()
  {
    Root = null;
  }

  /// <summary>
  /// 要素の挿入を行います
  /// </summary>
  /// <param name="_data"></param>
  public void Insert(T _data)
  {
    Root = InsertRec(Root, _data);
  }

  /// <summary>
  /// 挿入のために再帰的に行います．
  /// </summary>
  /// <param name="_node"></param>
  /// <param name="_data"></param>
  /// <returns></returns>
  private Node<T> InsertRec(Node<T> _node, T _data)
  {
    //nullならばその場所に要素を挿入する．
    //そのために，return _nodeを行う．
    if (_node == null)
    {
      _node = new Node<T>(_data);
      return _node;
    }

    //挿入ノードの値が比較ノードの値よりも小さいならば，Leftを探索
    if (_data.CompareTo(_node.Data) < 0)
    {
      _node.Left = InsertRec(_node.Left, _data);
    }
    //大きいならば，Rightを探索
    else
    {
      _node.Right = InsertRec(_node.Right, _data);
    }
    return _node;
  }

  /// <summary>
  /// 要素の削除を行う．
  /// </summary>
  /// <param name="_data"></param>
  public void Delete(T _data)
  {
    Root = DeleteRec(Root, _data);
  }

  /// <summary>
  /// 要素の削除を行うために再帰的に行う．
  /// まずは削除ノードを発見し，二つの子ノードを持っているならば
  /// 右木部分の最小値を削除ノードにあてはめる．
  /// </summary>
  /// <param name="_node"></param>
  /// <param name="_data"></param>
  /// <returns></returns>
  private Node<T> DeleteRec(Node<T> _node, T _data)
  {
    if (_node == null) { return null; }

    // 削除ノードの値は比較ノードの値よりも小さいので，左木部分に存在する．
    if (_data.CompareTo(_node.Data) < 0)
    {
      _node.Left = DeleteRec(_node.Left, _data);
    }
    // 大きいので右木部分に存在する．
    else if (_data.CompareTo(_node.Data) > 0)
    {
      _node.Right = DeleteRec(_node.Right, _data);
    }
    // 同じならば削除ノードを消してその部分に子ノードを代入する．
    else
    {
      // 子ノードが二つならば右木部分の最小値を削除ノードにあてはめる．
      // あてはめたノードも削除したと考えられるので，削除を行う．
      if (_node.Left != null && _node.Right != null)
      {
        Node<T> _minNode = GetMinNode(_node.Right);
        _node.Data = _minNode.Data;
        _minNode.Right = DeleteRec(_node.Right, _minNode.Data);
      }
      // 子ノードが一つならば子ノードを親ノードにあてはめるのみ．
      else if (_node.Left != null)
      {
        return _node.Left;
      }
      else
      {
        return _node.Right;
      }
    }
    return _node;
  }

  /// <summary>
  /// 右子ノードのうち最小のものをとってくる．
  /// 最小のノード＝左子ノードがないノード
  /// </summary>
  /// <param name="_node"></param>
  private Node<T> GetMinNode(Node<T> _node)
  {
    if (_node.Left != null)
    {
      return GetMinNode(_node.Left);
    }
    return _node;
  }
}
//public class Example
//{
//  public static void Main()
//  {
//    BinarySearchTree<int> _tree = new BinarySearchTree<int>();
//    _tree.Insert(34);
//    _tree.Insert(51);
//    _tree.Insert(72);
//    _tree.Insert(17);
//    _tree.Insert(66);
//    _tree.Insert(35);
//    _tree.Insert(99);
//    _tree.Insert(1);
//    _tree.Delete(51);
//    _tree.Delete(34);
//    _tree.Delete(1);
//  }
//}