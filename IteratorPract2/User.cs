using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPract2
{
    public class User
    {
        public string Nombre { get; set; }

        Playlist playlist = new Playlist();

        public User(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void AgregarCancion(string Titulo)
        {
            playlist.Agregar(new Cancion(Titulo));
        }

        public void ReproducirPlayList() 
        { 
           playlist.CrearIterador().ReproducirTodas();
        }


    }
}