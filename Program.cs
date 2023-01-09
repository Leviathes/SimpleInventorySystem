// See https://aka.ms/new-console-template for more information

using Projects;

Player p = new Player();

bool isQuit = false;

while (!isQuit)
{
    var input = Console.ReadLine();
    if (input == "quit")
    {
        Console.WriteLine("Are you sure you want to exit? (Y/n)");
        if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
        {
            isQuit = true;
        }
    }
}
    
    