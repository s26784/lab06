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

    public IOrderedEnumerable<Animal> GetAnimals(string orderBy)
    {
        IList<Animal> animals = _animalRepository.GetAnimals();
        
        switch (orderBy.ToLower())
        {
            case "description":
                return animals.OrderBy(a => a.Description);
            case "category":
                return animals.OrderBy(a => a.Category);
            case "area":
                return animals.OrderBy(a => a.Area);
            default:
                return animals.OrderBy(a => a.Name);
        }
    }

    public Animal AddAnimal(AnimalDTO animalDTO)
    {
        Animal newAnimal = new Animal(animalDTO);
        _animalRepository.AddAnimal(newAnimal);
        return newAnimal;
    }

    public void UpdateAnimal(int idAnimal, AnimalDTO animalDto)
    {
        Animal animalToDelete = GetAnimal(idAnimal);
        _animalRepository.DeleteAnimal(animalToDelete);
        Animal updatedAnimal = new Animal(animalDto);
        _animalRepository.AddAnimal(updatedAnimal);
    }

    public void DeleteAnimal(int idAnimal)
    {

        Animal animalToDelete = GetAnimal(idAnimal);
        
        _animalRepository.DeleteAnimal(animalToDelete);
    }
    
    
    public Animal GetAnimal(int id)
    {
        Animal foundAnimal = null;

        foreach (Animal animal in _animalRepository.GetAnimals())
        {
            if (animal.IdAnimal == id)
            {
                foundAnimal = animal;
            }
        }

        if (foundAnimal == null)
        {
            throw new System.Exception("Animal with given ID not found.");
        }

        return foundAnimal;
    }

}