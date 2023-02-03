namespace Projects;

public class Player : Entity
{
    
    
    public Player(string name, int type) {
        this.name = name;
        this.type = type;
        
    
    }

    public Player()
    {
        Console.Write("Name: ");
        var input = Console.ReadLine();
        name = input;
        Console.WriteLine("Welcome," + name + "!");
        type = 1;


    }

    public void Visit(string place)
    {
        var val = "";
        switch (place)
        {
            case "-h": 
                Console.WriteLine("|--------------------------------------------------------|");
                Console.WriteLine("| Here is a list of the places you can currently visit:  |");
                ShowPlacesKnown();
                break;
            case "grensten" :
                Console.WriteLine(Locations.Grentia.name);
                break;
        }
    }

    public void ShowPlacesKnown()
    {
       
        
        Console.WriteLine("|\n|");
    }


}