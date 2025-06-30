using MadaResto.Application.DTOs;

namespace MadaResto.Application.Services;

/// <summary>
/// Service interface for managing culinary experiences.
/// </summary>
public interface ICulinaryExperienceService
{
    /// <summary>
    ///     Creates a new culinary experience.
    ///    Returns the ID of the created experience.
    /// </summary>
    /// <param name="experienceDto"></param>
    /// <returns></returns>
    Task<Guid> CreateCulinaryExperienceAsync(CulinaryExperienceCreationDTO experienceDto);


    /// <summary>
    /// Updates an existing culinary experience.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="experienceDto"></param>
    /// <returns></returns>
    Task<bool> UpdateCulinaryExperienceAsync(Guid id, CulinaryExperienceCreationDTO experienceDto);


    /// <summary>
    /// Deletes a culinary experience by its ID.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> DeleteCulinaryExperienceAsync(Guid id);

    /// <summary>
    /// Retrieves a culinary experience by its ID.
    /// If the experience is not found, returns null.
    /// If the experience is found, returns the CulinaryExperienceDTO.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CulinaryExperienceDTO?> GetCulinaryExperienceByIdAsync(Guid id);

    /// <summary>
    ///    Retrieves all culinary experiences.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CulinaryExperienceDTO>> GetAllCulinaryExperiencesAsync();
}