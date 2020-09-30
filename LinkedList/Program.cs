using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Add("Red");
            linkedList.Add("Blue");
            linkedList.Add("Green");
            linkedList.Add("Yellow");

            linkedList.Print();

            linkedList.getFirst();

            Console.WriteLine(linkedList.Contains("Red"));
            Console.WriteLine(linkedList.Contains("Purple"));
        }
    }
}
