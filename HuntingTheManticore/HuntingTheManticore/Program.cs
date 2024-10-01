Console.Title = "Hunting the Manicore";

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

// Start of game player 1 get asked where to station the Manticore
int range = AskForNumberInRage();

Console.Clear();

// Player 2's turn to try and shoot the Manticore and save the city

Console.WriteLine("Player 2, its your turn.");

do {
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("STATUS: Round: " + round + " City: " + cityHealth + "/15 Manticore: " + manticoreHealth + "/10");

    int damage = DamageForRound(round);

    Console.WriteLine("The cannon is expected to deal " + damage + " damage this round.");

    int targetRange = AskForTargetRage();

    bool hit = DidTheCannonHit(targetRange, range);

    if (hit == true)
    {
        manticoreHealth -= damage;
    }

    if (manticoreHealth > 0)
    {
        cityHealth -= 1;
    }

    round++;
}
while (manticoreHealth > 0 && cityHealth > 0 );

//End of game

Console.WriteLine("--------------------------------------------------------------------------");

if (manticoreHealth <= 0)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}
else if (cityHealth <= 0)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("The city of Consolas has been destroyed!");
}




/* -----------------------------------------------------Methods------------------------------------------------------------*/

int AskForNumberInRage()
    {
    int number;
        do
        {
            Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? (0-100)");
    
            number = Convert.ToInt32(Console.ReadLine());

        }
        while (number < 0 || number > 100);

    return number;

    }


int DamageForRound(int round)
{
    int damage = 1;

    if (round % 3 == 0 || round % 5 == 0)
    {
        damage = 5;
    }
    else if(round % 3 == 0 && round % 5 == 0)
    {
        damage = 10;
    }

    return damage;
}

int AskForTargetRage()
{
    int number;
    do
    {
        Console.WriteLine("Enter desired cannon rage (0-100): ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    while (number < 0 || number > 100);

    return number;
}

bool DidTheCannonHit(int targetRange, int range)
{
    string textToPlayer = "";
    bool hit = false;

    if (targetRange != range) {

        Console.ForegroundColor = ConsoleColor.Red;

        if (targetRange > range)
        {
            textToPlayer = "That round OVERSHOT the target.";
        }
        else if (targetRange < range)
        {
            textToPlayer = "That round FELL SHORT of the target.";
        }

        hit = false;

    }
    else if (targetRange == range)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        textToPlayer = "That round was a DIRECT HIT!";

        hit = true;
    }

    Console.WriteLine(textToPlayer);

    return hit;

}
