// See https://aka.ms/new-console-template for more information

Console.WriteLine("User 1, enter a number between 0 and 100:");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if ( inputNumber < 0 || inputNumber > 100)
{
    Console.WriteLine("User 1, enter a number between 0 and 100:");
    inputNumber = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

Console.WriteLine("User 2, guess the number.");

int guessedNumber;

do
{
    Console.WriteLine("What is your next guess? ");
    guessedNumber = Convert.ToInt32(Console.ReadLine());

    if (guessedNumber == inputNumber)
    {
        Console.WriteLine("You guessed the right number!");
    }
    else if (guessedNumber < inputNumber)
    {
        Console.WriteLine(guessedNumber + " is too low.");
        continue;
    }
    else if (guessedNumber > inputNumber)
    {
        Console.WriteLine(guessedNumber + " is too high.");
        continue;
    }
}
while (guessedNumber != inputNumber);

