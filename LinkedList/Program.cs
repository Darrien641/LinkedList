using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList MenuList = new LinkedList();
            LinkedList linkedList = new LinkedList();
            string Input = "";
            MenuList.Add("1.Show Head");
            MenuList.Add("2.Add Item");
            MenuList.Add("3.Remove Item");
            MenuList.Add("4.Search for Item");
            MenuList.Add("5.Print");
            MenuList.Add("6.Exit");

            linkedList.Add("Red");
            linkedList.Add("Blue");
            linkedList.Add("Green");
            linkedList.Add("Yellow");
            while (Input != "6") { 
                Console.WriteLine("Enter An Option");
                MenuList.Print();
                Input = Console.ReadLine();

                if (int.Parse(Input) == 1)
                {
                    Console.WriteLine(linkedList.getFirst());
                }
                if (Input == "2")
                {
                    Input = "";
                    Console.WriteLine("What would you like to add?");
                    Input = Console.ReadLine();
                    linkedList.Add(Input);
                }
                if (Input == "3")
                {
                    Input = "";
                    Console.WriteLine("Which Item would You like to remove?");
                    Input = Console.ReadLine();
                    linkedList.Remove(Input);
                    Console.WriteLine(Input + " Was removed");
                }
                if (Input == "4")
                {
                    Input = "";
                    Console.WriteLine("What Item would you like to search for?");
                    Input = Console.ReadLine();
                    if (linkedList.Contains(Input) != null)
                    {
                        Console.WriteLine("Item is in list");
                    }
                    else
                    {
                        Console.WriteLine("That Item is not in this list");
                    }
                }
                if (Input == "5")
                {
                    linkedList.Print();
                }
            }

            //linkedList.Print();

            //linkedList.getFirst();

            //Console.WriteLine(linkedList.Contains("Red"));
            //Console.WriteLine(linkedList.Contains("Purple"));
        }
    }
}
