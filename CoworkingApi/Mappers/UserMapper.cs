using Coworking.Appi.Business.Models;
using CoworkingApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoworkingApi.Mappers
{
    public static class UserMapper
    {
        public static User Map(UserModel model)
        {
            return new User()
            {
                Active = model.Active,
                CreateDate = model.CreateDate,
                Email = model.Email,
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname
            };
        }
    }
}
