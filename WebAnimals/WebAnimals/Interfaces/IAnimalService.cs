using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Services;

public interface IAnimalService
{
    List<Animal> GetAnimals(string orderBy);
    int AddAnimal(Animal animal);
    int UpdateAnimal(AnimalDTO animalDto);
    int DeleteAnimal(int idAnimal);
    
}