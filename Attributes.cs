namespace Projects;

public struct Attributes
{
    private int strength { get; set; }
    private int endurance { get; set; }
    private int dexterity { get; set; }
    private int charisma { get; set; }
    private int inteligence { get; set; }
    private int spirit { get; set; }

    public Attributes()
    {
        strength = 1;
        endurance = 1;
        dexterity = 1;
        charisma = 1;
        inteligence = 1;
        spirit = 1;
    }
}