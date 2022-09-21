using System;
using System.Collections.Generic;


namespace DataStructures
{

    class Program
    {
        static void Main(string[] args)
        { 
            var myList = new SortedListArray();
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });
            myList.Add(new Item { ProductName = "milk", Quantity = 1 });
            myList.Add(new Item { ProductName = "apples", Quantity = 1 });
            myList.Add(new Item { ProductName = "biscuits", Quantity = 2 });
            myList.Add(new Item { ProductName = "carrots", Quantity = 1 });

            for (int i = 0; i <myList.Count; i++)
            {
                Console.WriteLine($"{ myList.Retrieve(i).ProductName} \t {myList.Retrieve(i).Quantity}");
            }
            Console.WriteLine();
            myList.Remove(new Item { ProductName = "carrots" });
           
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"{ myList.Retrieve(i).ProductName} \t {myList.Retrieve(i).Quantity}");
            }
            int position;
            bool found = myList.Found(new Item { ProductName = "carrots" }, out position);
            if (found)
            {
                Console.WriteLine($"Found at position: {position}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadLine();
        }
    }
}
