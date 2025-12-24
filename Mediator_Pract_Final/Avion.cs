using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Pract_Final
{
    public class Avion
    {
        public string Nombre { get; }

        ITorreControl _Torre;

        public Avion(string Nombre, ITorreControl torre)
        {
            this.Nombre = Nombre;
            _Torre = torre;

            _Torre.RegistrarAvion(this);
        }

        public void Despegar()
        {
            Console.WriteLine($"Vuelo {Nombre} despegando...");
            _Torre.NotificarDespegue(this);
        }

        public void Aterizar()
        {
            Console.WriteLine($"Vuelo {Nombre} aterrizando...");
            _Torre.NotificarAterizaje(this);
        }

        public void SolicitarAterizaje()
        {
            Console.WriteLine($"Vuelo {Nombre} solicita permiso para aterrizar.");
            _Torre.SolicitarAterizaje(this);
        }

        public void SolicitarDespegue()
        {
            Console.WriteLine($"Vuelo {Nombre} solicita permiso para despegar.");
            _Torre.SolicitarDespegue(this);
        }


    }
}