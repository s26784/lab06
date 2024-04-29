using Microsoft.AspNetCore.Http.HttpResults;
using WebAnimals.DTO;
using WebAnimals.Exception;
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

    public List<Animal> GetAnimals(string orderBy)
    {
        return _animalRepository.GetAnimals(orderBy);

    }

    public int AddAnimal(Animal animal)
    {
        return _animalRepository.AddAnimal(animal);
    }

    public int UpdateAnimal(AnimalDTO animalDto)
    {
        return _animalRepository.UpdateAnimal(animalDto);
    }

    public int DeleteAnimal(int idAnimal)
    {
        return _animalRepository.DeleteAnimal(idAnimal);
    }
    

}