using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPract1
{
    public class PlaylistIterator
    {
        List<Cancion> Canciones;
        int position = 0;

        public PlaylistIterator(List<Cancion> Canciones)
        {
            this.Canciones = Canciones;
        }

        public bool TieneSiguiente() 
        { 
          return position < Canciones.Count;
        }

        public Cancion Siguiente() 
        { 
           return Canciones[position++];
        }

    }
}