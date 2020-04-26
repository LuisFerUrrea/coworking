using Coworking.Appi.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.EntityConfig
{
    public class Officces2RoomsEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Officces2RoomsEntity> entityBuilder)
        {
            entityBuilder.ToTable("Officces2Room");

            entityBuilder.HasOne(x => x.Office).WithMany(x => x.Office2Room).HasForeignKey(x => x.OfficeId);
            entityBuilder.HasOne(x => x.Room).WithMany(x => x.Office2Room).HasForeignKey(x => x.RoomId);

            entityBuilder.HasKey(x=>new { x.OfficeId,x.RoomId});
            entityBuilder.Property(x => x.OfficeId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();

        }

    }
}
