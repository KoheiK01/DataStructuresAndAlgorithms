using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// 最小ヒープを実装しているクラスです．
/// </summary>
/// <typeparam name="T"></typeparam>
public class Heap<T> where T : IComparable<T>
{
  private List<T> data;

  public Heap()
  {
    data = new List<T>();
  }

  public void Insert(T _item)
  {
    data.Add(_item);
    int _child = data.Count - 1;
    while (_child > 0)
    {
      int _parent = (_child - 1) / 2;
      if (data[_child].CompareTo(data[_parent]) >= 0)
      {
        break;
      }

      T _temp = data[_child];
      data[_child] = data[_parent];
      data[_parent] = _temp;

      _child = _parent;
    }
  }

  public int Count { get { return data.Count; } }

  public T DeleteMin()
  {
    if (data.Count == 0) throw new InvalidOperationException("The heap is empty");

    T _min = data[0];
    data[0] = data[data.Count - 1];
    data.RemoveAt(data.Count - 1);

    int _parent = 0;

    while (2 * _parent + 1 <= data.Count - 1)
    {
      int _leftChild = 2 * _parent + 1;//親から見た左子ノード
      int _rightChild = 2 * _parent + 2;//親から見た右子ノード
      int _minChild = _leftChild;

      if (_rightChild <= data.Count - 1 && data[_leftChild].CompareTo(data[_rightChild]) > 0)
      {
        _minChild = _rightChild;
      }

      if (data[_minChild].CompareTo(data[_parent]) < 0)
      {
        T _temp = data[_minChild];
        data[_minChild] = data[_parent];
        data[_parent] = _temp;

        _parent = _minChild;
      }
      else break;
    }
    return _min;
  }
}



/// <summary>
/// 二分探索木を実装します．
/// ノードクラスの実装と木は別で考えます．ヒープとの違いです．
/// ヒープではその構造を使用して配列で制御できます．
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

  public void Insert(T _data)
  {
    Root = InsertRec(Root, _data);
  }

  private Node<T> InsertRec(Node<T> _node, T _data)
  {
    if (_node == null)
    {
      _node = new Node<T>(_data);
      return _node;
    }

    if (_data.CompareTo(_node.Data) < 0)
    {
      _node.Left = InsertRec(_node.Left, _data);
    }
    else
    {
      _node.Right = InsertRec(_node.Right, _data);
    }
    return _node;
  }

  public void Delete(T _data)
  {
    Root = DeleteRec(Root, _data);
  }

  private Node<T> DeleteRec(Node<T> _node, T _data)
  {
    if (_node == null) { return null; }

    if (_data.CompareTo(_node.Data) < 0)//左の子をたどる
    {
      _node.Left = DeleteRec(_node.Left, _data);
    }
    else if (_data.CompareTo(_node.Data) > 0)//右の子をたどる
    {
      _node.Right = DeleteRec(_node.Right, _data);
    }
    else
    {
      if (_node.Left != null && _node.Right != null)
      {
        Node<T> _minNode = GetMinNode(_node.Right);
        _node.Data = _minNode.Data;
        _minNode.Right = DeleteRec(_node.Right, _minNode.Data);
      }
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

public class Example
{
  public static void Main()
  {
    BinarySearchTree<int> _tree = new BinarySearchTree<int>();
    _tree.Insert(34);
    _tree.Insert(51);
    _tree.Insert(72);
    _tree.Insert(17);
    _tree.Insert(66);
    _tree.Insert(35);
    _tree.Insert(99);
    _tree.Insert(1);
    _tree.Delete(51);
    _tree.Delete(34);
    _tree.Delete(1);
  }
}