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
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
            return current.next;
        }

        public void Print(string data)
        {
            Node current = front;
            if (front == null)
            {
                Console.WriteLine("List is empty!");
            }
            else 
            {
                while(current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
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
