using ApbdCwicznia5.Database;
using ApbdCwicznia5.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApbdCwicznia5.Controllers;

[ApiController]
[Route("/visits_controller")]
public class VisitsController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult AnimalVisits(int id)
    {
        var animals = StaticData.animals;
        var animal =  animals.FirstOrDefault(anm => anm.Id == id);
        if (animal == null)
            return NotFound($"Animal with id {id} was not found");

        var visits = StaticData.Visits.Where(vst => vst.Animal.Id == id);

        if (!visits.Any())
            return NotFound($"Animal with id {id} doesnt have any visits.");

        return Ok(visits);
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        StaticData.Visits.Add(visit);
        if(StaticData.animals.All(anm => anm.Id != visit.Animal.Id))
            StaticData.animals.Add(visit.Animal);
        return Created();
    }
}