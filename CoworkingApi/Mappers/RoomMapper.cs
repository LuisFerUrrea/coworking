using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class RoomMapper
    {

        public static Room Map(RoomModel model)
        {

            return new Room()
            {
                Capacity = model.Capacity,
                Id = model.Id,
                Name = model.Name
            };

        }

    }
}
