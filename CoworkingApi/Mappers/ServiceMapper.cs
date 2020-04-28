using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class ServiceMapper
    {

        public static Service Map(ServiceModel model)
        {

            return new Service()
            {
                Active = model.Active,
                Id = model.Id,
                Name = model.Name,
                Price = model.Price
            };

        }

    }
}
