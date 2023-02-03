// See https://aka.ms/new-console-template for more information

using Projects;

Player p = new Player();

bool isQuit = false;

while (!isQuit)
{
    Console.Write("=|> ");
    var input = Console.ReadLine();
    if (input == "quit")
    {
        Console.WriteLine("Are you sure you want to exit? (Y/n)");
        Console.Write("=|> ");
        if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
        {
            isQuit = true;
        }
    }
    else
    {
        
        string[] words = input.Split(" ");
        string firstword = words[0];
        
        switch (firstword.ToLower())
        {
            case "visit" :
                if (words.Length < 2)
                {
                    p.Visit("-h");
                    
                }
                else
                {
                    p.Visit(words[1].ToLower());
                }
                
                break;
        }
    }

    
}
    
    