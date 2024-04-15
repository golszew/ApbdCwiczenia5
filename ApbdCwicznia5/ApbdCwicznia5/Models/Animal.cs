namespace ApbdCwicznia5.Models;

public class Animal
{
    private static int GenID = 0;
    public int  Id { get; set; }
    
    public string Name { get; set; }

    public string Category { get; set; }

    public double Mass { get; set; }

    public string FurCollor { get; set; }

    public Animal(string name, string category, double mass, string furCollor)
    {
        Id = ++GenID;
        Name = name;
        Category = category;
        Mass = mass;
        FurCollor = furCollor;
    }
}