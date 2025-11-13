using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Practica_TorreControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITorreControl torre = new TorreControl();

            torre.RegistrarAvion(new Avion("Vuelo 101"));


        }
    }
}
