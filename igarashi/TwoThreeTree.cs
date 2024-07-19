//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices.WindowsRuntime;
//using System.Threading;

///// <summary>
///// 2 - 3木(B木)を実装します．
///// 2 - 3木(B木)では一般にノードクラスを定義します．
///// </summary>
///// <typeparam name="T"></typeparam>
//public class TwoThreeNode<T> where T : IComparable<T>
//{
//  public T LeafData;//葉であるならばデータを持つ
//  public T MinData;//1番目の子の子孫の最小値（索引情報ではない）
//  public T SecondMinKey;//2番目の子の子孫の最小値
//  public T ThirdMinKey;//3番目の子の子孫の最小値
//  public List<TwoThreeNode<T>> Children = new List<TwoThreeNode<T>>();
//  public bool IsLeaf => Children.Count == 0;//葉かどうか
//}

///// <summary>
///// 2 - 3木(B木)の実装クラスです．
///// </summary>
///// <typeparam name="T"></typeparam>
//public class TwoThreeTree<T> where T : IComparable<T>
//{
//  public TwoThreeNode<T> Root = null;

//  /// <summary>
//  /// 要素の挿入を行います
//  /// </summary>
//  /// <param name="_key"></param>
//  public void Insert(T _key)
//  {
//    if (Root == null)
//    {
//      Root = new TwoThreeNode<T> { LeafData = _key };
//    }
//    else
//    {
//      TwoThreeNode<T> _child = InsertRec(Root, _key);

//      //親ノードを追加しなければならない
//      if (_child != null)
//      {
//        TwoThreeNode<T> _newRoot = new TwoThreeNode<T>();
//        _newRoot.Children.Add(Root);
//        _newRoot.Children.Add(_child);
//        SetParentKey(_newRoot);
//        Root = _newRoot;
//      }
//    }
//  }

//  /// <summary>
//  /// 挿入のために再帰的に行います．
//  /// 戻り値bool(_grow)は木の高さが変更された場合にtrueになります．
//  /// </summary>
//  /// <param name="_node"></param>
//  /// <param name="_key"></param>
//  /// <returns></returns>
//  private TwoThreeNode<T> InsertRec(TwoThreeNode<T> _node, T _key)
//  {
//    //ノードが葉であるならば
//    if (_node.IsLeaf)
//    {
//      //これも葉である．新しいノードを作って返す．
//      return new TwoThreeNode<T> { LeafData = _key };
//    }

//    //_nodeの子で_dataが属する部分木を求める．
//    TwoThreeNode<T> _child = FindChild(_node, _key);

//    //_childへ_keyを挿入する．
//    TwoThreeNode<T> _newChild = InsertRec(_child, _key);
//    if (_newChild == null) return null;//兄弟は増えなかった

//    //_newChildを追加し，並び替えを行い，索引情報(Key)をセットする．
//    _node.Children.Add(_newChild);
//    SetParentKey(_node);

//    //_nodeの子が4つになったならば
//    if (_node.Children.Count == 4)
//    {
//      return SplitNode(_node);
//    }
//    else
//    {
//      //既に要素は追加したので，新しい親ノードに追加する必要はない
//      return null;
//    }
//  }

//  /// <summary>
//  /// 親の索引情報(Key)をセットする．
//  /// 並び替えを行うことで実現する．
//  /// </summary>
//  /// <param name="_parent"></param>
//  private void SetParentKey(TwoThreeNode<T> _parent)
//  {
//    List<TwoThreeNode<T>> _children = _parent.Children;

//    //子が葉であるならば葉の値で比較する
//    if (_children[0].IsLeaf)
//    {
//      _children.Sort((x, y) => x.LeafData.CompareTo(y.LeafData));
//      _parent.MinData = _children[0].LeafData;
//      _parent.SecondMinKey = _children[1].LeafData;
//      _parent.ThirdMinKey = _children.Count == 3 ? _children[2].LeafData : default;
//    }
//    else
//    {
//      _parent.MinData = _children[0].MinData;
//      _parent.SecondMinKey = _children[1].MinData;
//      _parent.ThirdMinKey = _children.Count == 3 ? _children[2].MinData : default;
//    }
//  }

//  /// <summary>
//  /// 子が4つになった場合に分割を行う．
//  /// </summary>
//  /// <param name="_node"></param>
//  /// <returns></returns>
//  private TwoThreeNode<T> SplitNode(TwoThreeNode<T> _node)
//  {
//    TwoThreeNode<T> _rightChild = new TwoThreeNode<T>();

//    //右側2つの要素を追加して，並び替えを行い，索引情報(Key)をセットする．
//    _rightChild.Children.AddRange(_node.Children.GetRange(2, 2));
//    SetParentKey(_rightChild);

//    //左側2つの要素を削除して，並び替えを行い，索引情報(Key)をセットする．
//    _node.Children.RemoveRange(2, 2);
//    SetParentKey(_node);
//    return _rightChild;
//  }

//  /// <summary>
//  /// _keyが属するchildを求める
//  /// </summary>
//  /// <param name="_parent"></param>
//  /// <param name="_key"></param>
//  /// <returns></returns>
//  private TwoThreeNode<T> FindChild(TwoThreeNode<T> _parent, T _key)
//  {
//    //挿入されるデータの2番目の子の子孫の最小値より小さいならば，
//    if (_key.CompareTo(_parent.SecondMinKey) < 0)
//    {
//      //1番目の子孫に_keyは属する
//      return _parent.Children[0];
//    }
//    //子供が二つしかいないならば，または
//    //挿入されるデータの3番目の子の子孫の最小値より小さいならば，
//    else if (_parent.Children.Count == 2 || _key.CompareTo(_parent.ThirdMinKey) < 0)
//    {
//      //2番目の子孫に_keyは属する
//      return _parent.Children[1];
//    }
//    else
//    {
//      //3番目の子孫に_keyは属する
//      return _parent.Children[2];
//    }
//  }
//}

//public class Example
//{
//  public static void Main()
//  {
//    TwoThreeTree<int> tree = new TwoThreeTree<int>();
//    tree.Insert(61);
//    tree.Insert(79);
//    tree.Insert(28);
//    tree.Insert(35);
//    tree.Insert(86);
//    tree.Insert(63);
//    tree.Insert(100);
//    tree.Insert(105);
//  }
//}