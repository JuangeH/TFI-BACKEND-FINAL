﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Models
{
    public class VideojuegoModel
    {
        public VideojuegoModel()
        {
            novedadModels = new HashSet<NovedadModel>();
            trofeosModel = new HashSet<TrofeoModel>();
            adquisicionesModel = new HashSet<AdquisicionModel>();
            tiempoDeJuegoModel = new HashSet<TiempoDeJuegoModel>();
            valoracionModel = new HashSet<ValoracionModel>();
            reseñaModel = new HashSet<ReseñaModel>();
            videojuegoEstiloModels = new HashSet<VideojuegoEstiloModel>();
            videojuegoGeneroModels = new HashSet<VideojuegoGeneroModel>();
            videojuegoInteresModels = new HashSet<VideojuegoInteresModel>();
            foroModels = new HashSet<ForoModel>();
        }

        public int Videojuego_ID { get; set; }
        public string Nombre { get; set; }
        public int Plataforma_ID { get; set; }
        public int SteamAppid { get; set; }
        public string? Header_image { get; set; }
        public int? Metacritic_score { get; set; }
        public string? Metacritic_url { get; set; }
        public int? Recomendaciones { get; set; }
        //public List<EstiloDeJuego> Estilos { get; set; }
        //public List<Genero> Generos { get; set; }
        //public List<Novedad> Novedades { get; set; }
        //public List<Reseña> Reseñas { get; set; }
        //public List<Valoracion> Valoraciones { get; set; }
        public PlataformaModel Plataforma { get; set; }
        public ICollection<NovedadModel> novedadModels { get; set; }
        public ICollection<TrofeoModel> trofeosModel { get; set; }
        public ICollection<AdquisicionModel> adquisicionesModel { get; set; }
        public ICollection<TiempoDeJuegoModel> tiempoDeJuegoModel { get; set; }
        public ICollection<ValoracionModel> valoracionModel { get; set; }
        public ICollection<ReseñaModel> reseñaModel { get; set; }
        public ICollection<VideojuegoEstiloModel> videojuegoEstiloModels { get; set; }
        public ICollection<VideojuegoGeneroModel> videojuegoGeneroModels { get; set; }
        public ICollection<VideojuegoInteresModel> videojuegoInteresModels { get; set; }
        public ICollection<ForoModel> foroModels { get; set; }
    }
}
