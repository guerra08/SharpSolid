namespace SharpSolid.L;

public class Drive
{
    public int Size { get; set; }
    public int ReadSpeed { get; set; }
    public int WriteSpeed { get; set; }

    public Drive(int size, int read, int write)
    {
        Size = size;
        read = read;
        write = write;
    }

    public void WriteString(String data)
    {
        Console.WriteLine("Writing string to drive...");
    }
}