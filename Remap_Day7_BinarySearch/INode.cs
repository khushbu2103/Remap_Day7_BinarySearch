using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day7_BinarySearch
{
    internal class INode
    {
        public class Node<T> where T : IComparable
        {
            public T Key { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }

            public Node(T key)
            {
                Key = key;
                Left = null;
                Right = null;
            }
        }
    }
}
