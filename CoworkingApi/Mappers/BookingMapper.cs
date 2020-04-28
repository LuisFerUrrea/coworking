using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class BookingMapper
    {

        public static Booking Map(BookingModel model)
        {

            return new Booking()
            {
                BookingDate = model.BookingDate,
                CreateDate = model.CreateDate,
                Id = model.Id,
                OfficeId = model.OfficeId,
                RentWorkSpace = model.RentWorkSpace,
                RoomId = model.RoomId,
                UserId = model.UserId

            };

        }

    }
}
