using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteIterators
{
    class PostorderIterator : BTIterator
    {
        public PostorderIterator(Tree tree)
            : base(tree)
        {
            Name = "Postorder Iterator";
        }

        public override Node CurrentItem()
        {
            if (IsDone())
                return null;

            return _items[_current];
        }

        public override void First()
        {
            _current = 0;
        }

        public override bool IsDone()
        {
            return _current < 0 || _current >= _items.Count;
        }

        public override void Next()
        {
            _current++;
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
