﻿using API_Business.Request;
using API_Business.Response;
using AutoMapper;
using Core.Domain.ApplicationModels;
using Core.Domain.DTOs;
using Core.Domain.Models;
using Core.Domain.Response.Business;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.Helpers.ResultClasses;

namespace Api.Mapping
{
    public class ApiMapping : Profile
    {
        public ApiMapping()
        {
            //CreateMap<VideojuegoModel, Apps>();
            //CreateMap<Apps, VideojuegoModel>()
            //    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.name));

            //CreateMap<Privileges, PrivilegesPutRequest>();
            //CreateMap<PrivilegesPutRequest, Privileges>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.PrivilegeNewName))
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.ConcurrencyStamp, opt => opt.MapFrom(src => src.concurrencyStamp));

            //CreateMap<Privileges, PrivilegesPostRequest>();
            //CreateMap<PrivilegesPostRequest, Privileges>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.PrivilegeName));

            //CreateMap<IdentityResult, GenericResult<RegisterDto>>()
            //    .ForMember(dest => dest.Errors, opt => opt.MapFrom(src => src.Errors.Select(p => p.Description)))
            //    .ForPath(dest => dest.Data.Code, opt => opt.MapFrom(src => src.Errors.Select(p => p.Code)));

            //CreateMap<ChangePasswordDto, ChangePasswordRequest>();

            CreateMap<VideojuegoModel, VideojuegoResponse>()
                .ForMember(dest => dest.VideojuegoEstilo, opt => opt.MapFrom(src => src.videojuegoEstiloModels))
                .ForMember(dest => dest.VideojuegoGenero, opt => opt.MapFrom(src => src.videojuegoGeneroModels))
                .ForMember(dest => dest.Plataforma, opt => opt.MapFrom(src => src.Plataforma));

            CreateMap<EstiloModel, EstiloResponse>();
            CreateMap<GeneroModel, GeneroResponse>();
            CreateMap<PlataformaModel, PlataformaResponse>();

            CreateMap<VideojuegoEstiloModel, VideojuegoEstiloResponse>()
                .ForMember(dest => dest.estilo, opt => opt.MapFrom(src => src.estiloModel));

            CreateMap<VideojuegoGeneroModel, VideojuegoGeneroResponse>()
                .ForMember(dest => dest.genero, opt => opt.MapFrom(src => src.generoModel));


            CreateMap<ComentarioModel, ComentarioResponse>()
                .ForMember(dest => dest.Creador, opt => opt.MapFrom(src => src.usuario.UserName))
                .ForMember(dest => dest.ComentarioPadre_Codigo, opt => opt.MapFrom(src => src.ComentarioPadre_ID))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Comentario_ID))
                .ForMember(dest => dest.Contenido, opt => opt.MapFrom(src => src.Contenido))
                .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => src.FechaCreacion))
                .ForMember(dest => dest.CantidadVotos, opt => opt.MapFrom(src => src.puntuacionModels.Count))
                .ForMember(dest => dest.PromedioPuntaje, opt => opt.MapFrom(src => src.puntuacionModels.Any()
                    ? src.puntuacionModels.Average(p => p.Puntaje)
                    : 0.0));

            CreateMap<ForoModel, ForoResponse>()
                .ForMember(dest => dest.NombreVideoJuego, opt => opt.MapFrom(src => src.videojuego.Nombre))
                .ForMember(dest => dest.NombreUsuarioCreador, opt => opt.MapFrom(src => src.usuario.UserName))
                .ForMember(dest => dest.Visitas, opt => opt.MapFrom(src => src.foroUsuarioVisitaModels.Count))
                .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Foro_ID))
                .ForMember(dest => dest.favorito, opt => opt.MapFrom(src => src.foroUsuarioFavoritoModels))

                .ForMember(dest => dest.favorito, opt => opt.MapFrom((src, dest, _, context) =>
                    src.foroUsuarioFavoritoModels.Any(f => f.User_ID == (string)context.Items["LoggedUserID"])))

                .ForMember(dest => dest.CantidadComentarios, opt => opt.MapFrom(src => src.comentarioModels.Count));

            CreateMap<VideojuegoModel, VideojuegoForoReponse>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                 .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Videojuego_ID));

          

        }
    }
}
