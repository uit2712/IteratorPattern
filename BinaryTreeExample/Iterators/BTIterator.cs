using BinaryTreeExample.Entities;
using System.Collections.Generic;

namespace BinaryTreeExample.Iterators
{
    abstract class BTIterator : IIterator<Node>
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

        public Node CurrentItem()
        {
            if (IsDone())
                return null;

            return _items[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current < 0 || _current >= _items.Count;
        }

        public void Next()
        {
            _current++;
        }
    }
}
