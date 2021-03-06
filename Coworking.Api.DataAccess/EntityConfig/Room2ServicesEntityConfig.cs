﻿using Coworking.Appi.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class Room2ServicesEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Room2ServicesEntity> entityBuilder)
        {
            entityBuilder.ToTable("Room2Services");

            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Room2Services).HasForeignKey(x => x.RoomId);
            entityBuilder.HasOne(x => x.Service).WithMany(x => x.Room2Services).HasForeignKey(x => x.ServiceId);

            entityBuilder.HasKey(x => new { x.RoomId, x.ServiceId });
            entityBuilder.Property(x => x.RoomId).IsRequired();
            entityBuilder.Property(x => x.ServiceId).IsRequired();

        }

    }
}
