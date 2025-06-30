using AutoMapper;
using MadaResto.Application.DTOs;
using MadaResto.Application.Repositories;
using MadaResto.Application.Services;
using MadaResto.Domain.Entities;

namespace MadaResto.Infrastructure.Services;

public class CulinaryExperienceService : ICulinaryExperienceService
{
    private readonly ICulinaryExperienceRepository culinaryExperienceRepository;
    private readonly IMapper mapper;

    public CulinaryExperienceService(
        ICulinaryExperienceRepository culinaryExperienceRepository,
        IMapper mapper
    )
    {
        this.culinaryExperienceRepository = culinaryExperienceRepository;
        this.mapper = mapper;
    }
    public async Task<Guid> CreateCulinaryExperienceAsync(CulinaryExperienceCreationDTO experienceDto)
    {
        var newExperience = new CulinaryExperience(experienceDto.Description, experienceDto.Location);
        await culinaryExperienceRepository.AddAsync(newExperience);
        return newExperience.Id;
    }

    public async Task<bool> DeleteCulinaryExperienceAsync(Guid id)
    {
        var existingExp = await culinaryExperienceRepository.GetByIdAsync(id);
        if (existingExp == null) return false;
        await culinaryExperienceRepository.DeleteAsync(existingExp);
        return true;
    }

    public async Task<IEnumerable<CulinaryExperienceDTO>> GetAllCulinaryExperiencesAsync()
    {
        var experiences = await culinaryExperienceRepository.GetAllAsync();
        return mapper.Map<IEnumerable<CulinaryExperienceDTO>>(experiences);
    }

    public async Task<CulinaryExperienceDTO?> GetCulinaryExperienceByIdAsync(Guid id)
    {
        var expericence = await culinaryExperienceRepository.GetByIdAsync(id);
        if (expericence == null)
        {
            return null;
        }
        return mapper.Map<CulinaryExperienceDTO>(expericence);

    }

    public async Task<bool> UpdateCulinaryExperienceAsync(Guid id, CulinaryExperienceCreationDTO experienceDto)
    {
        var existingExp = await culinaryExperienceRepository.GetByIdAsync(id);
        if (existingExp == null) return false;
        existingExp.UpdateDescription(experienceDto.Description);
        existingExp.UpdateLocation(experienceDto.Location);
        await culinaryExperienceRepository.UpdateAsync(existingExp);
        return true;
    }
}