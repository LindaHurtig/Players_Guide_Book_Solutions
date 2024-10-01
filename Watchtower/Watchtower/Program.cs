// See https://aka.ms/new-console-template for more information

string directionX = "";
string directionY = "";

Console.WriteLine("Write an X value:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write an Y value:");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 && y == 0){
    Console.WriteLine("The enemy is here!");
}
else 
{ 
    if (x != 0)
    {
       if (x < 0)
        {
            directionX = "W";
        }
        else if (x > 0)
        {
            directionX = "E";
        }
    }

    if (y != 0)
    {    
        if (y < 0)
        {
            directionY = "S";
        }
        else if ( y > 0)
        {
            directionY = "N";
        }

    }

    Console.WriteLine("Enemy is coming from " + directionY + directionX);

}







