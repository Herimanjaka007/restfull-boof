using MadaResto.Application.Repositories;
using MadaResto.Domain.Entities;
using MadaResto.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MadaResto.Infrastructure.Repositories;

public class CulinaryExperienceRepository : ICulinaryExperienceRepository
{
    private readonly MadaRestoDbContext _context;

    public CulinaryExperienceRepository(MadaRestoDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task AddAsync(CulinaryExperience experience)
    {
        await _context.CulinaryExperiences.AddAsync(experience);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var experience = await _context.CulinaryExperiences.FindAsync(id)
            ?? throw new KeyNotFoundException($"CulinaryExperience with ID {id} not found.");
        _context.CulinaryExperiences.Remove(experience);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<CulinaryExperience>> GetAllAsync()
    {
        return await _context.CulinaryExperiences.ToListAsync();
    }

    public async Task<CulinaryExperience?> GetByIdAsync(Guid id)
    {
        return await _context.CulinaryExperiences.FindAsync(id);
    }

    public async Task UpdateAsync(CulinaryExperience experience)
    {
        var existingExperience = await _context.CulinaryExperiences.FindAsync(experience.Id)
            ?? throw new KeyNotFoundException($"CulinaryExperience with ID {experience.Id} not found.");
        _context.CulinaryExperiences.Update(existingExperience);
        await _context.SaveChangesAsync();
    }
}
