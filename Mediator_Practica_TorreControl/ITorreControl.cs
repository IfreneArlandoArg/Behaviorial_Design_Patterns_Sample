using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Practica_TorreControl
{
    public interface ITorreControl
    {
        void NotificarDespegue(Avion avion);
        void NotificarAterrizaje(Avion avion);
        void RegistrarAvion(Avion avion);
    }
}