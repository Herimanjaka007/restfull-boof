namespace MadaResto.Application.DTOs;

public class CulinaryExperienceUpdateDTO
{
    public string Description { get; private set; }
    public string? Location { get; private set; }

    public CulinaryExperienceUpdateDTO(string description, string? location)
    {
        Description = description;
        Location = location;
    }
}