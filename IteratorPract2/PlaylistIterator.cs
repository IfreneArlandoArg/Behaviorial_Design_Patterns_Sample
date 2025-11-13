using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPract2
{
    public class PlaylistIterator
    {
        List<Cancion> Canciones;
        int position = 0;

        public PlaylistIterator(List<Cancion> Canciones)
        {
            this.Canciones = Canciones;
        }

        private bool TieneSiguiente() 
        { 
          return position < Canciones.Count;
        }

        private Cancion Siguiente() 
        { 
         return Canciones[position++];
        }

        public void ReproducirTodas()
        {
            while (TieneSiguiente())
            {
                
                Console.WriteLine("Reproduciendo: " + Siguiente().Titulo);
            }
        }


    }
}