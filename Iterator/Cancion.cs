using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    // Clase que representa una Canción
    public class Cancion
    {
        public string Titulo { get; }

        public Cancion(string titulo)
        {
            Titulo = titulo;
        }
    }

    // Iterador concreto
    public class PlaylistIterator
    {
        private List<Cancion> _canciones;
        private int _posicion = 0;

        public PlaylistIterator(List<Cancion> canciones)
        {
            _canciones = canciones;
        }

        public bool TieneSiguiente()
        {
            return _posicion < _canciones.Count;
        }

        public Cancion Siguiente()
        {
            return _canciones[_posicion++];
        }
    }

    // Colección (Playlist)
    public class Playlist
    {
        private List<Cancion> _canciones = new List<Cancion>();

        public void AgregarCancion(string titulo)
        {
            _canciones.Add(new Cancion(titulo));
        }

        public PlaylistIterator CrearIterador()
        {
            return new PlaylistIterator(_canciones);
        }
    }

}
