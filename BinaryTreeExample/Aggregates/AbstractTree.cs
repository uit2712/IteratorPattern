using BinaryTreeExample.Entities;
using BinaryTreeExample.Iterators;

namespace BinaryTreeExample.Aggregates
{
    abstract class AbstractTree : Tree
    {
        public abstract BTIterator CreateIterator();
    }
}
