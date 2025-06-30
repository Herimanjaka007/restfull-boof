using MadaResto.Application.DTOs;
using MadaResto.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MadaResto.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CulinaryExperienceController : ControllerBase
{
    private readonly ICulinaryExperienceService service;
    public CulinaryExperienceController(ICulinaryExperienceService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<CulinaryExperienceDTO>> GetAllCulinaryExperiences()
    {
        return await service.GetAllCulinaryExperiencesAsync();
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CulinaryExperienceDTO>> GetCulinaryExperienceById(Guid id)
    {
        var experience = await service.GetCulinaryExperienceByIdAsync(id);
        if (experience == null) return NotFound();
        return Ok(experience);
    }

    [HttpPost]
    public async Task<ActionResult> CreateCulinaryExperience(CulinaryExperienceCreationDTO culinaryExperienceCreationDTO)
    {
        var guid = await service.CreateCulinaryExperienceAsync(culinaryExperienceCreationDTO);
        return CreatedAtAction(nameof(GetCulinaryExperienceById), new { Id = guid }, null);
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteCulinaryExperience(Guid id)
    {
        var isDeleted = await service.DeleteCulinaryExperienceAsync(id);
        if (isDeleted)
            return NoContent();
        return NotFound();
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateCulinaryExperience(Guid id, CulinaryExperienceCreationDTO culinaryExperienceCreationDTO)
    {
        var isUpdated = await service.UpdateCulinaryExperienceAsync(id, culinaryExperienceCreationDTO);
        if (isUpdated)
            return NoContent();
        return NotFound();
    }

}