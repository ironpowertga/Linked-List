using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkData<T>
    {
        public T Value { get; set; }

        public LinkData<T> NextElement { get; set;}

        public LinkData(T value)
        {
            Value = value;
        }
    }
}
