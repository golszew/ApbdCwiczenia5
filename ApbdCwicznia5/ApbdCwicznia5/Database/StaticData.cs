using ApbdCwicznia5.Models;

namespace ApbdCwicznia5.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal("Azor", "pies", 12.5, "rudy"), 
        new Animal("Filemon", "kot", 4.5, "czarny"), 
        new Animal("Osiol", "osiol", 40, "szary")
    };

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit(new DateTime(2024, 4, 10), animals[0], "Szybka kontrola", 100),
        new Visit(new DateTime(2024, 2, 22), animals[1], "Zastrzyk", 120),
        new Visit(new DateTime(2024, 1, 15), animals[0], "Ciecie pazurow", 200)
    };
}