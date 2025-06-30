using MadaResto.Domain.Entities;

namespace MadaResto.Application.Repositories;

public interface ICulinaryExperienceRepository
{
    Task<CulinaryExperience?> GetByIdAsync(Guid id);
    Task<IEnumerable<CulinaryExperience>> GetAllAsync();
    Task AddAsync(CulinaryExperience experience);
    Task UpdateAsync(CulinaryExperience experience);
    Task DeleteAsync(CulinaryExperience culinaryExperience);
}