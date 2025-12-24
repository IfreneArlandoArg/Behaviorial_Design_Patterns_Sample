using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Pract_Final
{
    public class TorreControl : ITorreControl
    {
        public string Nombre { get; }

        List<Avion> avionesEnVuelo = new List<Avion>();
        Avion avionEnPista = null;

        public TorreControl(string Nombre)
        {
          this.Nombre = Nombre;
            Console.WriteLine($"Torre de Control {Nombre} operativa.");
        }

        public void NotificarAterizaje(Avion avion)
        {

            if(avionEnPista.Nombre == avion.Nombre) 
            {
                avionEnPista = null;
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Aterizaje completa.");
            }
            else
            {
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : No esta autorizada a aterizar");
            }
        }

        public void NotificarDespegue(Avion avion)
        {
            if (avionEnPista.Nombre == avion.Nombre)
            {
                avionEnPista = null;
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Despegue completa.");
            }
            else
            {
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : No esta autorizada a despegar");
            }
        }

        public void RegistrarAvion(Avion avion)
        {
            avionesEnVuelo.Add(avion);
            Console.WriteLine($"Avión {avion.Nombre} registrado en la torre de control.");
        }

        public void SolicitarAterizaje(Avion avion)
        {
            if (avionEnPista is null)
            {
                avionEnPista = avion;
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Aterizaje Autorizado.");
            }
            else
            {
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Aterizaje Negado'\n{avionEnPista.Nombre} en pista.\nStand By!!!");
            }
        }

        public void SolicitarDespegue(Avion avion)
        {
            if (avionEnPista is null)
            {
                avionEnPista = avion;
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Despegue Autorizado.");
            }
            else
            {
                Console.WriteLine($"Torre {Nombre} a {avion.Nombre} : Despegue Negado'\n{avionEnPista.Nombre} en pista.\nStand By!!!");
            }
        }
    }
}