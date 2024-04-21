using Microsoft.AspNetCore.Mvc;
using WebAnimals.DTO;
using WebAnimals.Models;
using WebAnimals.Services;

namespace WebAnimals.Controllers;
[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    
    [HttpGet]
    public IActionResult GetAnimals(string orderBy = "name")
    {
        var animals = _animalService.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult AddAnimal(AnimalDTO animalDto)
    {
        _animalService.AddAnimal(animalDto);
        return NoContent();
    }

    
    [HttpPut("{idAnimal}")]
    public IActionResult UpdateAnimal(int idAnimal, AnimalDTO animalDTO)
    {
        _animalService.UpdateAnimal(idAnimal, animalDTO);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalService.DeleteAnimal(id);
        return NoContent();
    }
    
}