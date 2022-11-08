using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Services
{
    public class PeliculasService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula = new Pelicula()
            {
                Titulo = "The Batman",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2012, 01, 10)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2002, 05, 15)
            };
            return new List<Pelicula> { pelicula, pelicula2 };
        }
    }
}