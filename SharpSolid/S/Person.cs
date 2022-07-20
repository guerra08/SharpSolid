namespace SharpSolid.S;

// The person class only does what it expected to do.
public class Person : IPerson
{
    public String Country { get; }

    public Person(String country)
    {
        this.Country = country;
    }
    
    public void Talk()
    {
        Console.WriteLine("Hey, I'm talking right now!");
    }

    public bool IsBrazilian()
    {
        return Country.Equals("Brazil");
    }
}