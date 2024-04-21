using Microsoft.AspNetCore.Mvc;
using WebAnimals.Models;
using WebAnimals.Services;

namespace WebAnimals.Controllers;

public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }
    
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animalService.GetAnimals());
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(st => st.Idanimal == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult CreateAnimal(animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut("{id:int}")]
    public IActionResult Updateanimal(int id, Animal animal)
    {
        var animalToEdit= _animals.FirstOrDefault(s => s.Idanimal == id);

        if (animalToEdit == null)
        {
            return NotFound($"animal with id {id} was not found");
        }
        
        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult Deleteanimal(int id)
    {
        var animalToEdit= _animals.FirstOrDefault(s => s.Idanimal == id);
        if (animalToEdit == null)
        {
            return NoContent();
        }

        _animals.Remove(animalToEdit);
        return NoContent();
    }
    
}