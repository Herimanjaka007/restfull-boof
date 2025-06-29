namespace MadaResto.Domain.Entities;

public class CulinaryExperience
{
    public Guid Id { get; private set; }
    public string Description { get; private set; }
    public string? Location { get; private set; }
    public DateTime PublishedDate { get; private set; }

    public CulinaryExperience(string description, string? location = null)
    {
        Id = Guid.NewGuid();
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Location = location;
        PublishedDate = DateTime.UtcNow;
    }

    public void UpdateDescription(string newDescription)
    {
        if (string.IsNullOrWhiteSpace(newDescription))
            throw new ArgumentException("Description cannot be empty.", nameof(newDescription));

        Description = newDescription;
    }

    public void UpdateLocation(string? newLocation)
    {
        Location = newLocation;
    }
}
