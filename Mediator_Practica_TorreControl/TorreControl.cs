using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Practica_TorreControl
{
    public class TorreControl : ITorreControl
    {
        List<Avion> avionesEnVuelo = new List<Avion>();
        Avion avionAterrizando = null;
      

        public void NotificarAterrizaje(Avion avion)
        {
            if(avionAterrizando is null ) 
            {
                avionAterrizando = avion;
                Console.WriteLine($"Torre a {avion.Nombre}: permiso concedido para aterrizar.\n");
            }
            else
            {
                Console.WriteLine($"Torre a {avion.Nombre}: espere, {avionAterrizando.Nombre} está aterrizando.\n");
            }

            

        }

        public void NotificarDespegue(Avion avion)
        {
            if(avionAterrizando is null ) 
            { 
                
                Console.WriteLine($"Torre a {avion.Nombre} : permiso concedido para despegar.\n");
            }
            else 
            { 
               Console.WriteLine($"Torre a {avion.Nombre} : espere, {avionAterrizando.Nombre} está aterrizando.\n");
            }
        }

        public void RegistrarAvion(Avion avion)
        {
            avionesEnVuelo.Add(avion);
            Console.WriteLine($"Avión {avion.Nombre} registrado en la torre de control.\n");
        }
    }
}