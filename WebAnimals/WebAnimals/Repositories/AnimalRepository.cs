using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal(1, "Pusheck", "aaa", "Cat", "Ghyrf"),
        new Animal(2, "Otamendi", "bbb", "Dog", "adfg"),
        new Animal(3, "Dotter", "ccc", "Hamster", "dafgd"),
        new Animal(4, "Toady", "ddd", "Snake", "fdagfg"),
        new Animal(5, "Dillon", "eee", "Dog", "sdf")
    };
    

    public List<Animal> GetAnimals()
    {
        List<Animal> resultList = _animals;
        return resultList;
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }
    

    public void UpdateAnimal(int idAnimal, Animal animal)
    {
        throw new NotImplementedException();
    }

    public void DeleteAnimal(Animal animalToDelete)
    {
        _animals.Remove(animalToDelete);
    }
    
}