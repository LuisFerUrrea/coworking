using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class AdminMapper
    {
        public static Admin Map(AdminModel model)
        {
            return new Admin()
            {
                Email = model.Email,
                Name = model.Name,
                Phone = model.Phone
            };

        }
    }
}
