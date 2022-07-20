namespace SharpSolid.O;

public class Burger : Food
{
    public void Prepare()
    {
        Console.WriteLine("Cook patty...");
        Console.WriteLine("Assemble...");
        Console.WriteLine("It's done!");
    }

    public int ComputeCalories()
    {
        return 800;
    }
}