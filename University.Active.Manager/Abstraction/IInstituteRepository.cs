using System.Collections.Generic;
using System.Threading.Tasks;
using University.Active.Manager.Contracts.University;
using Institute = University.Active.Manager.Entity.Institute;

namespace University.Active.Manager.Abstraction;

public interface IInstituteRepository
{
    Task<List<Entity.Institute>> GetAllInstitutes();

    Task<Institute> AddInstitute(Institute institute);
}