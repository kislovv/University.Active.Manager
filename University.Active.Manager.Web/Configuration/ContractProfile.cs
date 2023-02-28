using AutoMapper;
using University.Active.Manager.Contracts.Event;

namespace University.Active.Manager.Web.Configuration;

public class ContractProfile : Profile
{
    public ContractProfile()
    {
        CreateMap<Entity.Event, Event>();
    }
}