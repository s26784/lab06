using WebAnimals.Models;
using WebAnimals.Repositories;

namespace WebAnimals.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        IEnumerable <Animal> animals = _animalRepository.FetchAnimals();
        return animals;
    }

    public int CreateAnimal(Animal newAnimal{
        
    }
}