using System;
using System.Threading.Tasks;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Abstraction;

public interface IUserRepository
{
    Task<User> GetUserByLogin(string login);
    Task<User> AddUser(User profile);
    Task<User> GetUserById(Guid id);
}