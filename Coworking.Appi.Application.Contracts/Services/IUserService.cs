using Coworking.Appi.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.Application.Contracts.Services
{
    public interface IUserService
    {

        Task<User> AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task DeleteUser(int id);
        Task<User> UpdateUser(User user);

    }
}
