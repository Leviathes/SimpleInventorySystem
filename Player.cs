namespace Projects;

public class Player : Entity
{








    public Player(string name, int type) {
        this.name = name;
        this.type = type;

        name = new string("Herbok");
        gb = new newGreetBehaviours();
        inv = new Inventory();
        tb = new TransactionBroker();
    }


}