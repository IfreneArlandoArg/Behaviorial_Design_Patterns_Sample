using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_ControlTower_Airport
{
    // --- Interfaz del Mediador ---
    public interface ITorreControl
    {
        void RegistrarAvion(Avion avion);
        void SolicitarAterrizaje(Avion avion);
        void NotificarDespegue(Avion avion);
    }

    // --- Clase concreta del Mediador ---
    public class TorreControl : ITorreControl
    {
        private List<Avion> _avionesEnVuelo = new List<Avion>();
        private Avion _avionAterrizando = null;

        public void RegistrarAvion(Avion avion)
        {
            _avionesEnVuelo.Add(avion);
            Console.WriteLine($" {avion.Nombre} registrado en la torre de control.");
        }

        public void SolicitarAterrizaje(Avion avion)
        {
            if (_avionAterrizando == null)
            {
                _avionAterrizando = avion;
                Console.WriteLine($" Torre a {avion.Nombre}: permiso concedido para aterrizar.");
            }
            else
            {
                Console.WriteLine($" Torre a {avion.Nombre}: espere, {_avionAterrizando.Nombre} está aterrizando.");
            }
        }

        public void NotificarDespegue(Avion avion)
        {
            if (_avionAterrizando == avion)
            {
                Console.WriteLine($" {avion.Nombre} ha aterrizado con éxito.");
                _avionAterrizando = null;
            }
            else
            {
                Console.WriteLine($" {avion.Nombre} ha despegado.");
            }
        }
    }

    // --- Clase Colleague (Avión) ---
    public class Avion
    {
        public string Nombre { get; }
        private ITorreControl _torre;

        public Avion(string nombre, ITorreControl torre)
        {
            Nombre = nombre;
            _torre = torre;
            _torre.RegistrarAvion(this);
        }

        public void SolicitarAterrizaje()
        {
            Console.WriteLine($" {Nombre} solicita aterrizaje...");
            _torre.SolicitarAterrizaje(this);
        }

        public void Aterrizar()
        {
            Console.WriteLine($" {Nombre} aterrizando...");
            _torre.NotificarDespegue(this);
        }

        public void Despegar()
        {
            Console.WriteLine($" {Nombre} despegando...");
            _torre.NotificarDespegue(this);
        }
    }


}
