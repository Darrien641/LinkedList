using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private Node front;

        public void Add(string data)
        {
            if (front == null)
            {
                front = new Node(data);
            }
            else
            {
                Node current = front;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
            }
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
                while (current.next != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
                Console.WriteLine(current.data);
            }
        }
        public void addFirst(string data)
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
        }
        public string getFirst()
        {
            if (front == null)
            {
                return "List is Empty!";
            }
            return front.data;
        }
        public void Remove(string data)
        {
            Node current = front;
            while (current.next != null)
            {
                string NodeData = current.next.data;
                if (NodeData == data)
                {
                    current.next = current.next.next;
                }
                else if (data == front.data) 
                {
                    NodeData = front.data;
                    front = front.next;
                }
                current = current.next;
            }
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
