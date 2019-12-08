using BinaryTreeExample.Aggregates;
using BinaryTreeExample.ConcreteIterators;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteAggregates
{
    class PostorderTree : AbstractTree
    {
        public override BTIterator CreateIterator()
        {
            return new PostorderIterator(this);
        }
    }
}
