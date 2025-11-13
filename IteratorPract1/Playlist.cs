using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPract1
{
    public class Playlist
    {
        List<Cancion> Canciones = new List<Cancion>();

        public void Agregar(Cancion cancion)
        {
            Canciones.Add(cancion);
        }

        public PlaylistIterator CrearIterador()
        {
            return new PlaylistIterator(Canciones);
        }
    }
}