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
            MenuList.Add("\n1.Show Head");
            MenuList.Add("2.Add Item");
            MenuList.Add("3.Remove Item");
            MenuList.Add("4.Search for Item");
            MenuList.Add("5.Print");
            MenuList.Add("6.Exit\n");

            linkedList.Add("red");
            linkedList.Add("blue");
            linkedList.Add("green");
            linkedList.Add("yellow");
            while (Input != "6" ) { 
                Console.WriteLine("\nEnter An Option");
                MenuList.Print();
                Input = Console.ReadLine();
                Console.WriteLine();
                if (Input == "1")
                {
                    Console.WriteLine(linkedList.getFirst());
                    Console.WriteLine("");
                }
                if (Input == "2")
                {
                    Input = "";
                    Console.WriteLine("\nWhat would you like to add?");
                    Input = Console.ReadLine();
                    linkedList.Add(Input.ToLower());
                    Console.WriteLine("");
                }
                if (Input == "3")
                {
                    Input = "";
                    Console.WriteLine("\nWhich Item would You like to remove?");
                    Input = Console.ReadLine();
                    if (linkedList.Contains(Input.ToLower()) != null)
                    {
                        linkedList.Remove(Input.ToLower());
                        Console.WriteLine(Input + " Was removed\n");
                    }
                    else
                    {
                        Console.WriteLine(Input + " Items selected could not be removed. \nEither the Item does not exist or you should check your spelling.\n");
                    }
                    Console.WriteLine("");

                }
                if (Input == "4")
                {
                    Console.WriteLine("");
                    Input = "";
                    Console.WriteLine("What Item would you like to search for?");
                    Input = Console.ReadLine();
                    if (linkedList.Contains(Input.ToLower()) != null)
                    {
                        Console.WriteLine(Input +" is in list\n");
                    }
                    else
                    {
                        Console.WriteLine("\nThat Item is not in this list");
                    }
                    
                }
                if (Input == "5")
                {
                    Console.WriteLine("");
                    linkedList.Print();
                    
                }
                
            }
        }
    }
}
