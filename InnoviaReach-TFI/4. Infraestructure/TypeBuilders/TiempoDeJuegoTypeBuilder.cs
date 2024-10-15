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
    public class TiempoDeJuegoTypeBuilder : IEntityTypeConfiguration<TiempoDeJuegoModel>
    {
        public void Configure(EntityTypeBuilder<TiempoDeJuegoModel> builder)
        {
            builder.HasKey(x => x.Tiempo_ID);

            builder.Property(x => x.CantidadMinutos).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.usuario)
                  .WithMany(y => y.tiempoDeJuegoModel)
                  .HasForeignKey(z => z.User_ID);

            builder.HasOne(x => x.videojuego)
                   .WithMany(y => y.tiempoDeJuegoModel)
                   .HasForeignKey(z => z.Videojuego_ID);

            builder.ToTable("TiempoDeJuego");
        }
    }
}
