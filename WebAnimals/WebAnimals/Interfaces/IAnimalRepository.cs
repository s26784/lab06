using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Repositories;

public interface IAnimalRepository
{
        List<Animal> GetAnimals();

        void AddAnimal(Animal animal);
    
        void UpdateAnimal(int idAnimal, Animal animal);

        void DeleteAnimal(Animal animal);
    
}