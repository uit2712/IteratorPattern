using System;
using BinaryTreeExample.ConcreteIterators;
using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.InitData();

            BTIterator preorderIterator = new PreorderIterator(tree);
            BTIterator inorderIterator = new InorderIterator(tree);
            BTIterator postorderIterator = new PostorderIterator(tree);

            Print(preorderIterator);
            Print(inorderIterator);
            Print(postorderIterator);
        }

        static void Print(BTIterator iterator)
        {
            if (iterator == null)
                return;

            Console.WriteLine(iterator.Name);
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                Node item = iterator.CurrentItem();
                if (item != null)
                    Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
