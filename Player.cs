namespace Projects;

public class Player : Entity
{
    public string name = new string("");
    public newGreetBehaviours gb = new newGreetBehaviours();

    public Inventory inv = new Inventory();
    public TransactionBroker tb = new TransactionBroker();

    public Player(string name, int type) {
        this.name = name;
        this.type = type;
    }
}