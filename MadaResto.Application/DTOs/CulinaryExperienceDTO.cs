namespace MadaResto.Application.DTOs;

/// <summary>
/// Data Transfer Object for Culinary Experience Response.
/// </summary>
public class CulinaryExperienceDTO
{
    public Guid Id { get; private set; }
    public string Description { get; private set; } = default!;
    public string? Location { get; private set; }
    public DateTime PublishedDate { get; private set; }
}