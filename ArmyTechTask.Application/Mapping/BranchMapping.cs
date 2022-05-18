using ArmyTechTask.Application.Commons.DTOs;
using ArmyTechTask.Domain.Entities.Branches;
using AutoMapper;

namespace ArmyTechTask.Application.Mapping
{
    public class BranchMapping : Profile
    {
        public BranchMapping()
        {
            CreateMap<Branch, LookupResultDto>()
                .ForMember(p => p.Name, opt => opt.MapFrom(p => p.BranchName));
        }
    }
}
