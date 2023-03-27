using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Contracts.University;

namespace University.Active.Manager.Abstraction;

public interface IInstituteRepository
{
    Task<List<Entity.Institute>> GetAllInstitutes();
}