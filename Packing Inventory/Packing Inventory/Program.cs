using Packing_Inventory;
using Packing_Inventory.Item;

Pack pack = new Pack(10, 20, 30);

while (true)
{
    Console.WriteLine($"Your inventory is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentVolume}/{pack.MaxVolume} volume, {pack.CurrentWeight}/{pack.MaxWeight} weight");
    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");

    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    if (!pack.Add(newItem))
    {
        Console.WriteLine("Could not add this to your backpack");
    }

}