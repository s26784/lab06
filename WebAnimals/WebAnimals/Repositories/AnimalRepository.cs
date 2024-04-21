using WebAnimals.Models;

namespace WebAnimals.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal(1, "Pusheck", "Cat", 6.1, "Grey"),
        new Animal(2, "Otamendi", "Dog", 15.3, "White"),
        new Animal(3, "Dotter", "Hamster", 0.18, "Brown"),
        new Animal(4, "Toady", "Snake", 15.3, "White"),
        new Animal(5, "Dillon", "Dog", 15.3, "White")
    };


    public IEnumerable<Animal> FetchAnimals()
    {
        return _animals;
    }
}