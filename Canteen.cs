namespace DIKUCanteen;

public class Canteen
{
    public string Name { get; set; }
    // Cups property
    public int Cups { get; set; }

    // Constructor - default cups set to 100 if not specified
    public Canteen(string name, int cups = 100)
    {
        Name = name;
        Cups = cups;
    }

    public override string ToString()
    {
        return $"{Name} has {Cups} cups.";
    }
}
