using System;
using System.Collections.Generic;
using System.Threading;

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