namespace Projects;

public class Player : Entity
{
    private string[] PlacesKnown;
    
    public Player(string name, int type) {
        this.name = name;
        this.type = type;
        PlacesKnown = new string[0];
    }

    public Player()
    {
        Console.Write("Name: ");
        var input = Console.ReadLine();
        name = input;
        Console.WriteLine("Welcome," + name + "!");
        type = 1;
        PlacesKnown = new string[0];
    }

    public void Visit(string place)
    {
        switch (place)
        {
            case "-h": 
                Console.WriteLine("Here is a list of the places you can visit currently:");
                ShowPlacesKnown();
                break;
                
        }
    }

    public void ShowPlacesKnown()
    {
        for (int i = 0; i < PlacesKnown.Length; ++i)
        {
            Console.WriteLine(PlacesKnown[i]);
        }
    }


}