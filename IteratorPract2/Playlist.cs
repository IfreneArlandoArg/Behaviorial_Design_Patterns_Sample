using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPract2
{
    public class Playlist
    {
        List<Cancion> canciones = new List<Cancion>();

        public void Agregar(Cancion cancion)
        {
            canciones.Add(cancion);
        }

        public PlaylistIterator CrearIterador()
        {
            return new PlaylistIterator(canciones);
        }

    }
}