using Coworking.Api.DataAccess.EntityConfig;
using Coworking.Appi.DataAccess.Contracts;
using Coworking.Appi.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess
{   
    public class CoworkingDBContext : DbContext, ICoworkingDBContext
    {

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Officces2RoomsEntity> Officces2Rooms { get; set; }
        public DbSet<Room2ServicesEntity> Room2Services { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
      
        public CoworkingDBContext(DbContextOptions options) : base(options)
        {

        }   
        
        public CoworkingDBContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AdminEntityConfig.SetEntityBuilder(modelBuilder.Entity<AdminEntity>());
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            BookingEntityConfig.SetEntityBuilder(modelBuilder.Entity<BookingEntity>());
            OfficeEntityConfig.SetEntityBuilder(modelBuilder.Entity<OfficeEntity>());
            Officces2RoomsEntityConfig.SetEntityBuilder(modelBuilder.Entity<Officces2RoomsEntity>());
            Room2ServicesEntityConfig.SetEntityBuilder(modelBuilder.Entity<Room2ServicesEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());
            ServiceEntityConfig.SetEntityBuilder(modelBuilder.Entity<ServiceEntity>());

            base.OnModelCreating(modelBuilder);
        }

    }
}
