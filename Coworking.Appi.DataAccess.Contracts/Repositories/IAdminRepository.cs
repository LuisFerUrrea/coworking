using Coworking.Appi.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.DataAccess.Contracts.Repositories
{
    public interface IAdminRepository : IRepository<AdminEntity>
    {      
        Task<AdminEntity> Update(AdminEntity entity);      
    }
}
