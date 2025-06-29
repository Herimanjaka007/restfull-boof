using MadaResto.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadaResto.Infrastructure.Persistence;

public class MadaRestoDbContext : DbContext
{
    public DbSet<CulinaryExperience> CulinaryExperiences { get; set; }
    public MadaRestoDbContext(DbContextOptions options) : base(options)
    {

    }

}