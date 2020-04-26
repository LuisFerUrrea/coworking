using Coworking.Appi.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.DataAccess.Contracts.Repositories
{
    public interface IServicesRepository : IRepository<ServiceEntity>
    {
        Task<ServiceEntity> Update(ServiceEntity entity);
    }
}
