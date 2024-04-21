using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Services;

public interface IAnimalService
{
    IOrderedEnumerable<Animal> GetAnimals(string orderBy);
    Animal AddAnimal(AnimalDTO animalDTO);
    void UpdateAnimal(int idAnimal, AnimalDTO animalDto);
    void DeleteAnimal(int id);
    
}