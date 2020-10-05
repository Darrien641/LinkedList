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
            while (current != null)
            {
                Node NextNode = current.next;
                if (current.data == data)
                {
                    front = NextNode;
                    break;
                }
                if (NextNode.data == data)
                {
                    current.next = NextNode.next;
                    break;
                }
                current = current.next;
            }
        }
        public Node Contains(string data)
        {
            Node current = front;
            if (front == null)
            {
                return null;
            }
            while (current != null)
            {
                if (data == current.data)
                {
                    return current;
                }
                if (current.next == null)
                {
                    return null;
                }
                
                current = current.next;
            }
            return null;

        }

    }
}
