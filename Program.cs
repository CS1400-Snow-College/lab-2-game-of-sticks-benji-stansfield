//Benji Stansfield, 02-04-25, Lab 2 "Game of Sticks"
using System.Formats.Asn1;
using System.Xml.Serialization;

Console.Title = "Game of Sticks";
Console.Clear();

//Opening Screen
Console.WriteLine(@"
------------------------------
Welcome to the Game of Sticks!
------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(@"
You start with 20 sticks.
Players will take turns removing between 1 and 3 of the remaining sticks.
The player who takes the last stick loses.");
Console.WriteLine("Press any key to continue");
Console.ReadKey(true);
Console.Clear();

//Game turn
int numSticks = 20;
string player1 = "Player 1"; /*I don't know how to change players from 1 to 2*/
string player2 = "Player 2"; /*I don't know how to change players from 1 to 2*/
int maxSticks = 3;
int minSticks = 1;

while (numSticks > 0)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"{numSticks} sticks remaining");
    
    Console.Write("Player 1, how many sticks would you like to take? ");
    int sticksTaken = Convert.ToInt32(Console.ReadLine());

    if (maxSticks > numSticks)
        maxSticks = numSticks;
    else if (sticksTaken > maxSticks)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please choose between 1-3 sticks.");
        }
    else if (sticksTaken < minSticks)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please choose between 1-3 sticks.");
        }
    else if (sticksTaken >= minSticks)
        {
            numSticks = numSticks - sticksTaken;
            Console.Clear();
        }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please choose between 1-3 sticks");
    }
};

Console.WriteLine(@"
--------------
Player 1 wins!
--------------"); /*I don't know how to change the player, so this is the best that I could do*/
