using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contexto contexto = new Contexto();
            contexto.SetValor("x", 10);
            contexto.SetValor("y", 5);

            // Expresión: x + y + 3
            IExpresion expresion = new Suma(
                new Suma(new Variable("x"), new Variable("y")),
                new Numero(3)
            );

            Console.WriteLine($"Resultado: {expresion.Interpretar(contexto)}");
        }
    }
}
