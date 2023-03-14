using AutoMapper;
using University.Active.Manager.Contracts.Event;
using University.Active.Manager.Contracts.University;

namespace University.Active.Manager.Web.Configuration;

public class ContractProfile : Profile
{
    public ContractProfile()
    {
        CreateMap<Entity.Event, Event>().ReverseMap();
        CreateMap<Subject, Entity.Subject>().ReverseMap();
        CreateMap<Institute, Entity.Institute>().ReverseMap();
        CreateMap<Student, Entity.Student>().ReverseMap();
    }
}