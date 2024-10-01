// See https://aka.ms/new-console-template for more information


Console.WriteLine("Whats your name?");
string name = Console.ReadLine();
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What number do you want to see the price of?");
int choice = Convert.ToInt32(Console.ReadLine());

int price = 0;
string product = "";

switch (choice)
{
    case 1:
        product = "Rope";
        price = 10;
        break;
    case 2:
        product = "Torches";
        price = 16;
        break;
    case 3:
        product = "Climbing Equipment";
        price = 24;
        break;
    case 4:
        product = "Clean Water";
        price = 2;
        break;
    case 5:
        product = "Machete";
        price = 20;
        break;
    case 6:
        product = "Canoe";
        price = 200;
        break;
    case 7:
        product = "Food Supplies";
        price = 2;
        break;
}

if(name == "Linda")
{
    price /= 2;
}


Console.WriteLine($"{product} cost {Convert.ToString(price)} gold");