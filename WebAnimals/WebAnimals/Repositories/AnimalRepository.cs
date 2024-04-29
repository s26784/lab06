using System.Data.SqlClient;
using WebAnimals.DTO;
using WebAnimals.Models;

namespace WebAnimals.Repositories;

public class AnimalRepository : IAnimalRepository
{

    private IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    

    public List<Animal> GetAnimals(string orderBy)
    {
        
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();

        using var cmd = new SqlCommand();
        cmd.Connection = con;
        // SQL Injection bye bye
        string orderByValue = GetOrderBy(orderBy);
        cmd.CommandText = "SELECT IdAnimal, Name, Description, Category, Area FROM Animal ORDER BY " +orderByValue;

        var dr = cmd.ExecuteReader();
        List<Animal> resultList = new List<Animal>();

        while (dr.Read())
        {
            int idAnimal = (int)dr["IdAnimal"];
            string name = dr["Name"].ToString();
            string description = dr["Description"].ToString();
            string category = dr["Category"].ToString();
            string area = dr["Area"].ToString();
            resultList.Add(new Animal(idAnimal, name, description, category, area));
        }
        return resultList;
    }

    public int AddAnimal(Animal animal)
    {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        using SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Animal(Name, Description, Category, Area) VALUES(@Name, @Description, @Category, @Area)";
        cmd.Parameters.AddWithValue("@Name", animal.Name);
        cmd.Parameters.AddWithValue("@Description", animal.Description);
        cmd.Parameters.AddWithValue("@Category", animal.Category);
        cmd.Parameters.AddWithValue("@Area", animal.Area);
        
        int affectedRows = cmd.ExecuteNonQuery();
        return affectedRows;
    }
    

    public int UpdateAnimal(AnimalDTO animalDto)
    {
        (int id, string name, string description, string category, string area) = animalDto;
        
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "UPDATE Animal SET Name=@Name, Description = @Description, Category = @Category, Area = @Area WHERE IdAnimal = @IdAnimal";
        cmd.Parameters.AddWithValue("@IdAnimal", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Description", description);
        cmd.Parameters.AddWithValue("@Category", category);
        cmd.Parameters.AddWithValue("@Area", area);
        
        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }

    public int DeleteAnimal(int idAnimal)
    {
        using SqlConnection con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        using SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "DELETE FROM Animal WHERE IdAnimal = @IdAnimal";
        cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);
        
        int affectedRows = cmd.ExecuteNonQuery();
        return affectedRows;
    }
    
    private string GetOrderBy(string orderBy)
    {
        switch(orderBy.ToLower())
        {
            case "description":
            {
                return "Description";
            }
            case "category":
            {
                return "Category";
            }
            case "area":
            {
                return "Area";
            }
            default:
            {
                return "Name";
            }
        }
    }
    
}