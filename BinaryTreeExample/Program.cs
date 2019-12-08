using System;
using BinaryTreeExample.Aggregates;
using BinaryTreeExample.ConcreteAggregates;
using BinaryTreeExample.ConcreteIterators;
using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WithoutUsingAggregates();
            //UseAggregates();
        }

        static void WithoutUsingAggregates()
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

        static void UseAggregates()
        {
            AbstractTree inorderTree = new InorderTree();
            inorderTree.InitData();
            AbstractTree preorderTree = new PreorderTree();
            preorderTree.InitData();
            AbstractTree postorderTree = new PostorderTree();
            postorderTree.InitData();

            Print(inorderTree.CreateIterator());
            Print(preorderTree.CreateIterator());
            Print(postorderTree.CreateIterator());
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
