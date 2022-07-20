namespace SharpSolid.O;

public class Pizza : Food
{
    public void Prepare()
    {
        Console.WriteLine("Put toppings...");
        Console.WriteLine("Make wood fire...");
        Console.WriteLine("Cook...");
        Console.WriteLine("It's done!");
    }

    public int ComputeCalories()
    {
        return 1200;
    }
}