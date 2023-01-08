// See https://aka.ms/new-console-template for more information

using Projects;

Console.WriteLine("Hello, World!");


    Player james = new Player("James", 1);
    



public class GreetingBehaviour {
    public virtual void InitialGreeting() {
        Console.WriteLine("Hello, Nice to meet you.");
    }
    public virtual void FriendlyGreeting() {
        Console.WriteLine("Yo, waddup");
    }



}

public class newGreetBehaviours : GreetingBehaviour {
    public override void InitialGreeting()
    {
        Console.WriteLine("THIS ONE IS DIFFERENT");
    }
}
