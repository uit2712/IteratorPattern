using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteIterators
{
    class PreorderIterator : BTIterator
    {
        public PreorderIterator(Tree tree)
            : base(tree)
        {
            Name = "Preorder Iterator";
        }

        protected override void Loop(Node node)
        {
            if (node == null)
                return;

            _items.Add(node);
            Loop(node.Left);
            Loop(node.Right);
        }
    }
}
