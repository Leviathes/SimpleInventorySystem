namespace Projects;

public class Entity
{
    public int type = new int();
    public float[] pos = new float[2];
    
    public string name = new string(string.Empty);
    
    public Inventory inv = new Inventory();
    public TransactionBroker _transactionBroker = new TransactionBroker();
    public Attributes _attributes = new Attributes();
    public Skills _skills = new Skills();






}