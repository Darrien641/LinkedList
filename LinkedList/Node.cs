using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public string data;
        public Node next;

        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
}
