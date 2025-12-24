using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pract_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITorreControl torre = new TorreControl("T-ARG EZE");


            Avion avion1 = new Avion("AA123", torre);

            Avion avion2 = new Avion("KY980",torre);

            Avion avion3 = new Avion("ZY785", torre);

            avion1.SolicitarDespegue();
            avion2.SolicitarAterizaje();
            avion1.Despegar();
            avion2.SolicitarAterizaje();
            avion2.Aterizar();
            avion3.SolicitarDespegue();
            avion3.Despegar();



        }
    }
}
