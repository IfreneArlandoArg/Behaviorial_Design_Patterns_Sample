using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_ControlTower_Airport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TorreControl torre = new TorreControl();

            Avion avion1 = new Avion("Vuelo AR123", torre);
            Avion avion2 = new Avion("Vuelo LAT456", torre);
            Avion avion3 = new Avion("Vuelo AA789", torre);

            Console.WriteLine("\n--- Secuencia de eventos ---\n");

            avion1.SolicitarAterrizaje();
            avion2.SolicitarAterrizaje();

            avion1.Aterrizar();

            avion2.SolicitarAterrizaje();
            avion2.Aterrizar();

            avion3.Despegar();

        }
    }
}
