namespace WebAnimals.Models;

public class Animal
{
    public int IdAnimal { get; }

    public string Name { get; }

    public string Category { get; }

    public double Weight { get; }

    public string Color { get; }
    
    public Animal(int id, string name, string category, double weight, string color)
    {
        IdAnimal = id;
        Name = name;
        Category = category;
        Weight = weight;
        Color = color;
    }
    
}

