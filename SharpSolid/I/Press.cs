namespace SharpSolid.I;

public class Press : OilMachine
{
    public void DoWork()
    {
        Console.WriteLine("Doing Press work...");
    }

    public void CleanOil()
    {
        Console.WriteLine("Cleaning machine oil...");
    }
}