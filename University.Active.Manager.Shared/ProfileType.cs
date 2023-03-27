#if CONTRACT_ASSEMBLY
namespace University.Active.Manager.Contracts.User;
#else
namespace University.Active.Manager.Entity;
#endif
public enum ProfileType
{
    Student,
    UniversityAdministration
}