using System;
using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IProfileRepository
{
    Task<User> GetProfileByLogin(string login);
    Task<User> AddProfile(User profile);
    Task<User> GetProfileById(Guid id);
}