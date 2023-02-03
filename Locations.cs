using System.Numerics;

namespace Projects;





public static class Locales
{
    
}

public static class Locations
{

    public static Loc Grentia = new Loc("sdf", 0,0);

    static Locations()
    {
        
    }



}

public class Loc
{
    public Loc(string Name, float x, float y)
    {
        name = Name;
        pos.X = x;
        pos.Y = y;
    }
    
    public string name;
    public Vector2 pos;
    

}