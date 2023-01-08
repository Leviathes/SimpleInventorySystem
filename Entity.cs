namespace Projects;

public class Entity
{
    protected int type = new int();
    protected float[] pos = new float[2];
    
    protected string name;
    protected newGreetBehaviours gb;
    protected Inventory inv;
    protected TransactionBroker tb;

    
    protected struct Attributes {
      public int strength;
      public int endurance;
      public int dexterity;
      public int charisma;
      public int inteligence;
      public int spirit;
      
    }

    protected struct Skills
    {
        public int gathering;
        public int hunting;
        public int cooking;
        public int cleaning;
        public int navigation;
        public int leadership;
        public int fealty;
        public int heavy_weapons;
        public int light_weapons;
        public int dark_magic;
        public int holy_magic;
        public int missile_weapons;
        public int treachary;
    }

}