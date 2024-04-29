using WebAnimals.DTO;

namespace WebAnimals.Models;

public class Animal
{
    public int IdAnimal { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Area { get; set; }

    public Animal(int id, string name, string description, string category, string area)
    {
        IdAnimal = id;
        Name = name;
        Description = description;
        Category = category;
        Area = area;
    }
    
    public Animal() {}

    public Animal(AnimalDTO animalDto)
    {
        IdAnimal = animalDto.IdAnimal;
        Name = animalDto.Name;
        Description = animalDto.Description;
        Category = animalDto.Category;
        Area = animalDto.Area;
    }
    
}

