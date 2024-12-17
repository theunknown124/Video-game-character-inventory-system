using System;
using System.Collections.Generic;

class Program 
{
    public static void Main()
    {
        List<string> Inventory = new List<string>() {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5"};

        List<string> Storage = new List<string>();

        displayUI();

    }

    static int displayUI()
    {
        
        do 
        {

        int choice  =  Console.Read();

        //display UI
        Console.WriteLine("Video Game Character Inventory");
        Console.WriteLine();
        Console.WriteLine("Options:");
        Console.WriteLine("1. List all items in the inventory");
        Console.WriteLine("2. Add a new item to the inventory");
        Console.WriteLine("3. Remove a item from the inventory");
        Console.WriteLine("4. Move a item to Storage");
        Console.WriteLine("5. Exit Program");

        Console.WriteLine();


        } while (choice != 5);


    }

}