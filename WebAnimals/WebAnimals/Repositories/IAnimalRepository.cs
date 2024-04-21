using WebAnimals.Models;

namespace WebAnimals.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> FetchAnimals();
}