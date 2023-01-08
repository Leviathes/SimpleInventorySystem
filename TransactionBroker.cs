

public class TransactionBroker {
    private Inventory payer;
    private Inventory payee;


    public void Trade(int id, int amount) {
    
    }

    //TODO: How should the Transaction broker consume and distribute data?
    
    public TransactionBroker() {
        payer = new Inventory();
        payee = new Inventory();
    }

}