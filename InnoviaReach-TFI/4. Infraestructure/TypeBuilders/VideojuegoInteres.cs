﻿using Core.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Infraestructure.TypeBuilders
{
    public class VideojuegoInteres : IEntityTypeConfiguration<VideojuegoInteresModel>
    {
        public void Configure(EntityTypeBuilder<VideojuegoInteresModel> builder)
        {
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.videojuego)
                   .WithMany(y => y.videojuegoInteresModels)
                   .HasForeignKey(z => z.Videojuego_ID);

            builder.HasOne(x => x.usuario)
                   .WithMany(y => y.videojuegoInteresModel)
                   .HasForeignKey(z => z.User_ID);

            builder.ToTable("VideojuegoInteres");
        }
    }
}
