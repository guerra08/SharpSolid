namespace SharpSolid.D;

public class SimpleLogger : Logger
{
    public void LogInformation(string info)
    {
        Console.WriteLine("Log [info]: {0}", info);
    }
}