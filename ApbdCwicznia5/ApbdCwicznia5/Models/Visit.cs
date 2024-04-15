using System.Runtime.InteropServices.JavaScript;

namespace ApbdCwicznia5.Models;

public class Visit
{
    public Visit(DateTime date, Animal animal, string description, double price)
    {
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }

    public DateTime Date { get; set; }
    public Animal Animal { get; set; }
    public String Description { get; set; }
    public Double Price { get; set; }
}