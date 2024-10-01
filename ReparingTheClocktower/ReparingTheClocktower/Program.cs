// See https://aka.ms/new-console-template for more information

int input;

Console.WriteLine("Write a number: ");
input = Convert.ToInt16(Console.ReadLine());

if(input % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}
