using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeExample.Iterators
{
    interface IIterator<T> where T: class
    {
        void First();
        void Next();
        bool IsDone();
        T CurrentItem();
    }
}
