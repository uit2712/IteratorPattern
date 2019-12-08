using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.WriteLine(preorderIterator.ToString());
            Console.WriteLine(inorderIterator.ToString());
            Console.WriteLine(postorderIterator.ToString());
        }
    }
}
