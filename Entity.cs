namespace Projects;

public class Entity
{
    public int type = new int();
    public float[] pos = new float[2];
    
    
    public struct Attributes {
      private int strength;
      private int endurance;
      private int dexterity;
      private int charisma;
      private int inteligence;
      private int spirit;
      
    }

    public struct Skills
    {
        private int gathering;
        private int hunting;
        private int cooking;
        private int cleaning;
        private int navigation;
        private int leadership;
        private int fealty;
        private int heavy_weapons;
        private int light_weapons;
        private int dark_magic;
        private int holy_magic;
        private int missile_weapons;
        private int treachary;
    }

}