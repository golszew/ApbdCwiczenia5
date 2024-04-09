using ApbdCwicznia5.Models;

namespace ApbdCwicznia5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    // ctor
    public MockDb()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}