using ArmyTechTask.Application.InvoiceHeaders.DTOs;
using ArmyTechTask.Domain.Entities.InvoiceDetails;
using ArmyTechTask.Domain.Entities.InvoiceHeaders;
using AutoMapper;

namespace ArmyTechTask.Application.Mapping
{
    public class InvoiceHeaderMapping : Profile
    {
        public InvoiceHeaderMapping()
        {
            CreateMap<InvoiceHeader, InvoiceHeaderListResultDto>()
                .ForMember(p => p.BranchName, opt => opt.MapFrom(p => p.Branch.BranchName));

            CreateMap<InvoiceHeader, InvoiceHeaderDetailsResultDto>()
                .ForMember(p => p.BranchName, opt => opt.MapFrom(p => p.Branch.BranchName));

            CreateMap<InvoiceDetail, InvoiceHeaderListInvoiceDetailResultDto>();

        }
    }
}
