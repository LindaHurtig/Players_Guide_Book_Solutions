// See https://aka.ms/new-console-template for more information

Console.Title = "The Diffens of Consolas";

int row;
int column;

Console.WriteLine("Target Row?");
row = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Target Column?");
column = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Target Row " + row + " Column " + column);

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({ row }, { column - 1 })"); //Left Coord
Console.WriteLine($"({row - 1}, {column})");  // Buttom Coord
Console.WriteLine($"({row}, {column + 1})"); // Right Coord
Console.WriteLine($"({row + 1}, {column})"); // Top Coord

Console.Beep();

Console.ForegroundColor = ConsoleColor.White;



