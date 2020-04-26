using Coworking.Api.DataAccess.Repositories;
using Coworking.Appi.Application.Contracts.Services;
using Coworking.Appi.Application.Services;
using Coworking.Appi.DataAccess.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Appi.CrossCutting.Register
{
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            return services;
        }


        public static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();
            return services;
        }

        public static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IServicesRepository, ServicesRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }



    }
}
