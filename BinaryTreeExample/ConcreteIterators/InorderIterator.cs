using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteIterators
{
    class InorderIterator : BTIterator
    {
        public InorderIterator(Tree tree)
            : base(tree)
        {
        }

        protected override void Loop(Node node)
        {
            if (node == null)
                return;

            Loop(node.Left);
            _items.Add(node);
            Loop(node.Right);
        }
    }
}
