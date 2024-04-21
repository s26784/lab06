namespace WebAnimals.DTO;

public record AnimalDTO(
    int IdAnimal,
    string Name,
    string Description,
    string Category,
    string Area
);