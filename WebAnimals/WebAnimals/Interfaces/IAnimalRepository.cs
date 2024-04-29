using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Repositories;

public interface IAnimalRepository
{
        List<Animal> GetAnimals(string orderBy);

        int AddAnimal(Animal animal);
    
        int UpdateAnimal(AnimalDTO animalDto);

        int DeleteAnimal(int IdAnimal);
    
}