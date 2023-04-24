using System;
class Program{
    static void Main(string[] args)
    {
        Console.Write("Enter number of items: ");
        int numItems = int.Parse(Console.ReadLine());

        List<Item> items = new List<Item>();

        for (int i = 0; i < numItems; i++)
        {
            Console.WriteLine("Enter details for item {0}:", i + 1);

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Type (excluding 'ShowAll'): ");
            string type = Console.ReadLine();

            Item item = new Item(name, type);
            items.Add(item);
        }

        Console.Write("Enter search mode ('ShowAll' or item type): ");
        string searchMode = Console.ReadLine();

        if (searchMode == "ShowAll")
        {
            foreach (Item item in items)
            {
                Console.WriteLine("{0} ({1})", item.Name, item.Type);
            }

            Main(args);
        }
        else
        {
            List<Item> filteredItems = new List<Item>();

            foreach (Item item in items)
            {
                if (item.Type == searchMode)
                {
                    filteredItems.Add(item);
                }
            }

            if (filteredItems.Count > 0)
            {
                foreach (Item item in filteredItems)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("End", searchMode);
            }

            Main(args);
        }

        Console.WriteLine("End");
    }
}

class Item
{
    public string Name { get; set; }
    public string Type { get; set; }

    public Item(string name, string type)
    {
        Name = name;
        Type = type;
    }
}