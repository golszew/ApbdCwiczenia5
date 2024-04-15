using ApbdCwicznia5.Database;
using ApbdCwicznia5.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApbdCwicznia5.Controllers;
[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.animals;
        return Ok(animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    { 
        var animals = StaticData.animals;
        var animal =  animals.FirstOrDefault(anm => anm.Id == id);
        if (animal == null)
            return NotFound($"Animal with id {id} was not found");

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal([FromBody] Animal animal)
    {
        StaticData.animals.Add(animal);
        return Created();
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animals = StaticData.animals;
        var animalToEdit =  animals.FirstOrDefault(anm => anm.Id == id);
        if (animalToEdit == null)
            return NotFound($"Animal with id {id} was not found");
        StaticData.animals.Remove(animalToEdit);
        StaticData.animals.Add(animal);
        
        return NoContent();
    }

    [HttpDelete("{id:int}")]

    public IActionResult DeleteAnimal(int id)
    {
     
        var animals = StaticData.animals;
        var animalToEdit =  animals.FirstOrDefault(anm => anm.Id == id);
        if (animalToEdit == null)
            return NoContent();
        StaticData.animals.Remove(animalToEdit);
        return NoContent();

    }
}