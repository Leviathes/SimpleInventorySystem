// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


    person james = new person("James", 1);
    james.gb.InitialGreeting();
    james.inv.Add(23,120);
    james.inv.Add(34,300);
    james.inv.Subtract(23, 119);
    james.inv.Subtract(1,2);
    
    



public class entity {
    public int type = new int();
    public float[] pos = new float[2];

}

public class person : entity {
    public string name = new string("");
    public attributes a = new attributes();
    public newGreetBehaviours gb = new newGreetBehaviours();

    public Inventory inv = new Inventory();
    public TransactionBroker tb = new TransactionBroker();

    public person(string name, int type) {
            this.name = name;
            this.type = type;
    }
    
}


public struct attributes {
    int strength;
    int endurance;
}

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
