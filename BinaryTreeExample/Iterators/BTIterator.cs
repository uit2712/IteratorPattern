using BinaryTreeExample.Entities;
using System.Collections.Generic;

namespace BinaryTreeExample.Iterators
{
    abstract class BTIterator
    {
        protected List<Node> _items = new List<Node>();

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

        public override string ToString()
        {
            string result = string.Empty;
            foreach (Node item in _items)
                if (item != null)
                    result += item.Value + " ";

            return result + "\n";
        }
    }
}
