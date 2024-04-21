using WebAnimals.DTO;

namespace WebAnimals.Models;

public class Animal
{
    public int IdAnimal { get;}
    public string Name { get;}
    public string Description { get;}
    public string Category { get;}
    public string Area { get;}
    
    public Animal(int id, string name, string description, string category, string area)
    {
        IdAnimal = id;
        Name = name;
        Description = description;
        Category = category;
        Area = area;
    }

    public Animal(AnimalDTO animalDto)
    {
        IdAnimal = animalDto.IdAnimal;
        Name = animalDto.Name;
        Description = animalDto.Description;
        Category = animalDto.Category;
        Area = animalDto.Area;
    }
    
}

