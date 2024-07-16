using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// AVL木を実装します．
/// AVL木では一般にノードクラスを定義します．
/// </summary>
/// <typeparam name="T"></typeparam>
public class AVLNode<T> where T : IComparable<T>
{
  public T Data;
  public AVLNode<T> Left;
  public AVLNode<T> Right;
  public int Balance;

  public AVLNode(T _data)
  {
    Data = _data;
    Left = null;
    Right = null;
    Balance = 0;
  }
}

/// <summary>
/// AVL木の実装クラスです．
/// </summary>
/// <typeparam name="T"></typeparam>
public class AVLTree<T> where T : IComparable<T>
{
  public AVLNode<T> Root;

  public AVLTree()
  {
    Root = null;
  }

  /// <summary>
  /// 要素の挿入を行います
  /// </summary>
  /// <param name="_data"></param>
  public void Insert(T _data)
  {
    bool _grow;
    (Root, _grow) = InsertRec(Root, _data);
  }

  /// <summary>
  /// 挿入のために再帰的に行います．
  /// 戻り値bool(_grow)は木の高さが変更された場合にtrueになります．
  /// </summary>
  /// <param name="_node"></param>
  /// <param name="_data"></param>
  /// <returns></returns>
  private (AVLNode<T>, bool) InsertRec(AVLNode<T> _node, T _data)
  {
    bool _grow = true;

    //nullならばその場所に要素を挿入する．
    //そのために，return _nodeを行う．
    if (_node == null)
    {
      _node = new AVLNode<T>(_data);
      return (_node, true);
    }

    //挿入ノードの値が比較ノードの値よりも小さいならば，Leftを探索
    if (_data.CompareTo(_node.Data) < 0)
    {
      (_node.Left, _grow) = InsertRec(_node.Left, _data);

      //左の木の高さが+1されたならば，バランスは+1される．
      if (_grow) { _node.Balance++; (_node, _grow) = Balance(_node); }
    }

    //大きいならば，Rightを探索
    else
    {
      (_node.Right, _grow) = InsertRec(_node.Right, _data);

      //右の木の高さが+1されたならば，バランスは-1される．
      if (_grow) { _node.Balance--; (_node, _grow) = Balance(_node); }
    }

    return (_node, _grow);
  }

  /// <summary>
  /// バランスをとるための操作を行う．
  /// </summary>
  /// <returns></returns>
  private (AVLNode<T>, bool) Balance(AVLNode<T> _node)
  {
    if (_node.Balance == 0)
    {
      return (_node, false);
    }
    else if (Math.Abs(_node.Balance) == 1)
    {
      return (_node, true);
    }
    else
    {
      //左木部分が2長い
      if (_node.Balance == 2)
      {
        //左子ノードから見て左 > 右
        if (_node.Left.Balance > 0)
        {
          //右回転を行う
          _node = RotateRight(_node);
          _node.Balance = 0;
          return (_node, false);
        }
        //左子ノードから見て左 < 右
        else
        {
          //左回転を行って，右回転を行う
          _node.Left = RotateLeft(_node.Left);
          _node = RotateRight(_node);
          _node.Balance = 0;
          return (_node, false);
        }
      }
      //右木部分が2長い
      else
      {
        //右子ノードからみて左 < 右
        if (_node.Right.Balance < 0)
        {
          //左回転を行う
          _node = RotateLeft(_node);
          _node.Balance = 0;
          return (_node, false);
        }
        //右子ノードからみて左 < 右
        else
        {
          //右回転を行い，左回転を行う．
          _node.Right = RotateRight(_node.Right);
          _node = RotateLeft(_node);
          _node.Balance = 0;
          return (_node, false);
        }
      }
    }
  }

  /// <summary>
  /// 右回転を行う．
  /// </summary>
  /// <param name="_node"></param>
  /// <returns></returns>
  private AVLNode<T> RotateLeft(AVLNode<T> _node)
  {
    AVLNode<T> _right = _node.Right;
    _node.Right = _right.Left;
    _right.Left = _node;

    //ノードのバランスを求める．
    CalBalance(_node);
    return _right;
  }

  /// <summary>
  /// 左回転を行う．
  /// </summary>
  /// <param name="_node"></param>
  /// <returns></returns>
  private AVLNode<T> RotateRight(AVLNode<T> _node)
  {
    AVLNode<T> _left = _node.Left;
    _node.Left = _left.Right;
    _left.Right = _node;

    //ノードのバランスを求める．
    CalBalance(_node);
    return _left;
  }

  /// <summary>
  /// ノードのバランスを求める．
  /// </summary>
  /// <param name="_node"></param>
  private void CalBalance(AVLNode<T> _node)
  {
    _node.Balance = 0;
    if (_node.Left == null && _node.Right != null)
    {
      _node.Balance = -1;
    }
    else if (_node.Left != null && _node.Right == null)
    {
      _node.Balance = 1;
    }
  }
}

public class Example
{
  public static void Main()
  {
    AVLTree<int> tree = new AVLTree<int>();
    tree.Insert(34);
    tree.Insert(51);
    tree.Insert(72);
    tree.Insert(17);
    tree.Insert(44);
    tree.Insert(50);
  }
}