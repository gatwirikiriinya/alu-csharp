using System;
using InventoryLibrary; // Import the namespace of InventoryLibrary project

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sample objects creation
            Item item1 = new Item("Item1") { description = "Description of Item1", price = 10.99f };
            Item item2 = new Item("Item2") { description = "Description of Item2", price = 20.50f };
            User user1 = new User("User1");
            User user2 = new User("User2");
            Inventory inventory1 = new Inventory(user1.id, item1.id, 5);
            Inventory inventory2 = new Inventory(user2.id, item2.id, 10);

            // Instantiate JSONStorage
            JSONStorage storage = new JSONStorage();

            // Add sample objects
            storage.New(item1);
            storage.New(item2);
            storage.New(user1);
            storage.New(user2);
            storage.New(inventory1);
            storage.New(inventory2);

            // Save objects to JSON file
            storage.Save();

            // Load objects from JSON file
            storage.Load();

            // Get loaded objects
            var loadedObjects = storage.All();

            // Verify loaded objects
            foreach (var obj in loadedObjects.Values)
            {
                Console.WriteLine(obj.GetType().Name + " ID: " + (obj as BaseClass)?.id);
            }
        }
    }
}
