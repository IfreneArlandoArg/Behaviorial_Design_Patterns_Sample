using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            playlist.AgregarCancion("Imagine - John Lennon");
            playlist.AgregarCancion("Bohemian Rhapsody - Queen");
            playlist.AgregarCancion("Hotel California - Eagles");

            var iterador = playlist.CrearIterador();

            Console.WriteLine("Reproduciendo Playlist:\n");

            while (iterador.TieneSiguiente())
            {
                var cancion = iterador.Siguiente();
                Console.WriteLine( $"{cancion.Titulo}");
            }
        }
    }
}
