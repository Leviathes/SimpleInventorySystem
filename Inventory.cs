

public class Inventory
{
    private Dictionary<int,int> list = new Dictionary<int, int>();

    public void Add(int id, int amount) {
        var num = 0;
        if(!list.TryGetValue(id, out num)) {
            list.Add(id,amount);
        } else {
            list[id] += amount;
        }
    }

    public void Subtract(int id, int amount) {
        var num = 0;
    if(!list.TryGetValue(id, out num)) {
        Console.WriteLine("Attempted to remove items that do not exist.");
    } else {
        list[id] -= amount;
        if(list[id] < 0) {
            list.Remove(id);
        }
    }
    
    }

    public void print()
    {
        
    }
}