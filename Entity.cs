namespace Projects;

public class Entity
{
    protected int type = new int();
    protected float[] pos = new float[2];
    
    protected string name = new string(string.Empty);
    
    protected Inventory inv = new Inventory();
    protected TransactionBroker _transactionBroker = new TransactionBroker();
    protected Attributes _attributes = new Attributes();
    protected Skills _skills = new Skills();






}