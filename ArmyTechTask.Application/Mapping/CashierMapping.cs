using ArmyTechTask.Application.Cashiers.DTOs;
using ArmyTechTask.Domain.Entities.Cashiers;
using AutoMapper;

namespace ArmyTechTask.Application.Mapping
{
    public class CashierMapping : Profile
    {
        public CashierMapping()
        {
            CreateMap<Cashier, CashierListResultDto>()
                .ForMember(p => p.BranchName, opt => opt.MapFrom(p => p.Branch.BranchName));

            CreateMap<Cashier, CashierDetailsResultDto>()
                .ForMember(p => p.BranchName, opt => opt.MapFrom(p => p.Branch.BranchName));
        }
    }
}
