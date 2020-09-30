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

        public void Print()
        {
            Node current = front;
            if (front == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                while (current != null)
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
            }
            else
            {
                Node NewFront = new Node(data);
                NewFront.next = front;
                front = NewFront;
            }
            return front;
        }
        public void getFirst()
        {
            if (front == null)
            {
                Console.WriteLine("List is Empty!");
            }
            Console.WriteLine(front.data);
        }

        public Node Contains(string data)
        {
            Node current = front;
            if (data == current.data)
            {
                return current;
            }
            else
            {
                while (current != null && current.data != data)
                {
                    current = current.next;
                    
                }
                return null;
            }
            
        }

    }
}
