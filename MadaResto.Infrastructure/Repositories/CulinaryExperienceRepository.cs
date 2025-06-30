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

    public async Task DeleteAsync(CulinaryExperience culinaryExperience)
    {
        _context.CulinaryExperiences.Remove(culinaryExperience);
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
        _context.CulinaryExperiences.Update(experience);
        await _context.SaveChangesAsync();
    }
}
