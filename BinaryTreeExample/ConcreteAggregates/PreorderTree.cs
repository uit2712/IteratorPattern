using BinaryTreeExample.Aggregates;
using BinaryTreeExample.ConcreteIterators;
using BinaryTreeExample.Iterators;
namespace BinaryTreeExample.ConcreteAggregates
{
    class PreorderTree : AbstractTree
    {
        public override BTIterator CreateIterator()
        {
            return new PreorderIterator(this);
        }
    }
}
