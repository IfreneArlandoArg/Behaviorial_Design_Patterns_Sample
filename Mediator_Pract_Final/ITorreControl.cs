using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator_Pract_Final
{
    public interface ITorreControl
    {
        void SolicitarAterizaje(Avion avion);
        void SolicitarDespegue(Avion avion);
        void RegistrarAvion(Avion avion);
        void NotificarAterizaje(Avion avion);
        void NotificarDespegue(Avion avion);
    }
}