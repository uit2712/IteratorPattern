using BinaryTreeExample.Entities;
using System.Collections.Generic;

namespace BinaryTreeExample.Iterators
{
    abstract class BTIterator
    {
        public string Name { get; set; }
        protected List<Node> _items = new List<Node>();
        protected int _current = -1;

        public BTIterator(Tree tree)
        {
            InitItems(tree);
        }

        protected void InitItems(Tree tree)
        {
            if (tree != null)
                Loop(tree.Root);
        }

        protected abstract void Loop(Node node);
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract Node CurrentItem();
    }
}
