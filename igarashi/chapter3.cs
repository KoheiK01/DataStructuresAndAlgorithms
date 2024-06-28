using System;
using System.Collections.Generic;
using System.Threading;

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

  private (T, T) Swap(T _a, T _b)
  {
    return (_b, _a);
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

public class Example
{
  public static void Main()
  {
    Heap<int> _heap = new Heap<int>();
    _heap.Insert(31);
    _heap.Insert(21);
    _heap.Insert(48);
    _heap.Insert(9);
    _heap.DeleteMin();
    _heap.Insert(26);
    _heap.Insert(13);
    _heap.DeleteMin();

    while (_heap.Count > 0)
    {
      Console.WriteLine(_heap.DeleteMin());
    }
  }
}