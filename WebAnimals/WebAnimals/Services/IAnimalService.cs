using WebAnimals.Models;

namespace WebAnimals.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    int CreateAnimal(Animal newAnimal);
}