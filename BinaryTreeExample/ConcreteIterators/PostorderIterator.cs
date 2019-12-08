using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteIterators
{
    class PostorderIterator : BTIterator
    {
        public PostorderIterator(Tree tree)
            : base(tree)
        {
        }

        protected override void Loop(Node node)
        {
            if (node == null)
                return;

            Loop(node.Left);
            Loop(node.Right);
            _items.Add(node);
        }
    }
}
