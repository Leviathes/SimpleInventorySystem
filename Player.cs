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
    }

    public void Visit(string place)
    {
        
    }


}