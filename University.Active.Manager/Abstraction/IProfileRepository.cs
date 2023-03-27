using System;
using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IProfileRepository
{
    Task<Profile> GetProfileByLogin(string login);
    Task<Profile> AddProfile(Profile profile);
    Task<Profile> GetProfileById(Guid id);
}