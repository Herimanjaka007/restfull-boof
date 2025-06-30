using AutoMapper;
using MadaResto.Application.DTOs;
using MadaResto.Domain.Entities;

namespace MadaResto.Application.Mappings;

public class CulinaryExperienceProfile : Profile
{
    public CulinaryExperienceProfile()
    {
        CreateMap<CulinaryExperience, CulinaryExperienceDTO>();
    }
}