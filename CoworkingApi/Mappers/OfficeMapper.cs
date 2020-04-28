using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class OfficeMapper
    {

        public static Office Map(OfficeModel model)
        {

            return new Office()
            {
                Active = model.Active,
                Address = model.Address,
                City = model.City,
                HasIndividualWorkSpace = model.HasIndividualWorkSpace,
                Id = model.Id,
                AdminId = model.AdminId,
                Name = model.Name,
                NumberWorkSpaces = model.NumberWorkSpaces,
                Phone = model.Phone,
                PriceWorkSpaceDaily = model.PriceWorkSpaceDaily,
                PriceWorkSpaceMonthly = model.PriceWorkSpaceMonthly
            };

        }

    }
}
