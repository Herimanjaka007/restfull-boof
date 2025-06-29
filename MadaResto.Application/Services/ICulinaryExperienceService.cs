using MadaResto.Application.DTOs;

namespace MadaResto.Application.Services;

/// <summary>
/// Service interface for managing culinary experiences.
/// </summary>
public interface ICulinaryExperienceService
{
    Task<Guid> CreateCulinaryExperienceAsync(CulinaryExperienceCreationDTO experienceDto);
    Task<bool> UpdateCulinaryExperienceAsync(int id, CulinaryExperienceCreationDTO experienceDto);
    Task<bool> DeleteCulinaryExperienceAsync(int id);
    Task<CulinaryExperienceDTO> GetCulinaryExperienceByIdAsync(int id);
    Task<IEnumerable<CulinaryExperienceDTO>> GetAllCulinaryExperiencesAsync();
}