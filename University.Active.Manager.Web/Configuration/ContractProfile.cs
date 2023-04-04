using AutoMapper;
using University.Active.Manager.Contracts;
using University.Active.Manager.Contracts.University;
using University.Active.Manager.Contracts.User;

namespace University.Active.Manager.Web.Configuration;

public class ContractProfile : Profile
{
    public ContractProfile()
    { 

        // CreateMap<Subject, Entity.Subject>().ReverseMap();
        CreateMap<InstituteModel, Entity.Institute>().ReverseMap();
        CreateMap<UserRegistrationModel, Entity.User>().ReverseMap();
    }
}