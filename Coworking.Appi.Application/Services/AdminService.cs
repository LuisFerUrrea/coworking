using Coworking.Api.DataAccess.Mappers;
using Coworking.Appi.Application.Contracts.Services;
using Coworking.Appi.Business.Models;
using Coworking.Appi.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<string> GetAdminName(int id)
        {
            var entidad = await _adminRepository.Get(id);
            return entidad.Name;
        }

        public async Task<Admin> AddAdmin(Admin admin)
        {
          var addedEntity=await _adminRepository.Add(AdminMapper.Map(admin));
            return AdminMapper.Map(addedEntity);
        }
    }
}
