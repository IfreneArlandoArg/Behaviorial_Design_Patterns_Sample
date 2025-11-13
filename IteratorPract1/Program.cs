using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPract1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();

            playlist.Agregar(new Cancion("What a wonderful world - Armstrong."));
            playlist.Agregar(new Cancion("Easy shanking - Bob Marley."));
            playlist.Agregar(new Cancion("Konpa rousi - Tropicana d´Haïti."));

            var iterador = playlist.CrearIterador();

            Console.WriteLine("Reproduciendo Playlist:\n");

            while(iterador.TieneSiguiente()) 
            {
                Console.WriteLine(iterador.Siguiente().Titulo);
            }


        }
    }
}
