using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPract2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usuario = new User("Alice");

            usuario.AgregarCancion("Shape of You - Ed Sheeran");
            usuario.AgregarCancion("Blinding Lights - The Weeknd");
            usuario.AgregarCancion("Levitating - Dua Lipa");
            
            Console.WriteLine($"Reproduciendo playlist de {usuario.Nombre}:\n");


            usuario.ReproducirPlayList();

        }
    }
}
