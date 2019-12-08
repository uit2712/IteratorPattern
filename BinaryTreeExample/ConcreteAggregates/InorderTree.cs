using BinaryTreeExample.Aggregates;
using BinaryTreeExample.ConcreteIterators;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.ConcreteAggregates
{
    class InorderTree : AbstractTree
    {
        public override BTIterator CreateIterator()
        {
            return new InorderIterator(this);
        }
    }
}
