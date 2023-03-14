using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface ISubjectRepository
{
    Task<Subject> AddSubject(Subject subject);
    Task<Subject> GetSubjectById(long id);
    Task<Subject> UpdateSubject(Subject subject);
    Task<bool> DeleteSubject(Subject subject);
}