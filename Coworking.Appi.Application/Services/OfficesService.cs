﻿using Coworking.Api.DataAccess.Mappers;
using Coworking.Appi.Application.Contracts.Services;
using Coworking.Appi.Business.Models;
using Coworking.Appi.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Appi.Application.Services
{
    public class OfficesService : IOfficesService
    {

        private readonly IOfficeRepository _officeRepository;

        public OfficesService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }


        public async Task<Office> AddOffice(Office office)
        {
            var addedEntity = await _officeRepository.Add(OfficeMapper.Map(office));

            return OfficeMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Office>> GetAllOffices()
        {
            var admins = await _officeRepository.GetAll();

            return admins.Select(OfficeMapper.Map);
        }

        public async Task<Office> GetOffice(int id)
        {
            var entidad = await _officeRepository.Get(id);

            return OfficeMapper.Map(entidad);
        }

        public async Task DeleteOffice(int id)
        {
            await _officeRepository.DeleteAsync(id);
        }

        public async Task<Office> UpdateOffice(Office office)
        {
            var updated = await _officeRepository.Update(OfficeMapper.Map(office));

            return OfficeMapper.Map(updated);
        }
    }
}
