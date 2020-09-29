using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private Node front;

        public Node Add(string data)
        {
            if (front == null)
            {
                front = new Node(data);
                return front;
            }
            Node current = front;
            while (current != null)
            {
                
            }
            return front;
        }

        public Node addFirst(string data)
        {
            if (front == null)
            {
                front = new Node(data);
                return front;
            }
            else
            {
                Node current = front;
                front = new Node(data);
                return front;
            }
        }
    }
}
