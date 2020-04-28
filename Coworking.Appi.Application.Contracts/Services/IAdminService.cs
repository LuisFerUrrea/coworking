using Coworking.Appi.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.Application.Contracts.Services
{
    public interface IAdminService
    {
        Task<string> GetAdminName(int id);

        Task<Admin> AddAdmin(Admin admin);
    }
}
