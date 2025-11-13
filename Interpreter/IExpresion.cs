using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    // Contexto
    public class Contexto
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();

        public int GetValor(string variable) => variables[variable];
        public void SetValor(string variable, int valor) => variables[variable] = valor;
    }

    // Expresión abstracta
    public interface IExpresion
    {
        int Interpretar(Contexto contexto);
    }

    // Expresiones concretas
    public class Numero : IExpresion
    {
        private int valor;
        public Numero(int valor) => this.valor = valor;
        public int Interpretar(Contexto contexto) => valor;
    }

    public class Variable : IExpresion
    {
        private string nombre;
        public Variable(string nombre) => this.nombre = nombre;
        public int Interpretar(Contexto contexto) => contexto.GetValor(nombre);
    }

    public class Suma : IExpresion
    {
        private IExpresion izq, der;
        public Suma(IExpresion izq, IExpresion der)
        {
            this.izq = izq;
            this.der = der;
        }

        public int Interpretar(Contexto contexto) => izq.Interpretar(contexto) + der.Interpretar(contexto);
    }

}
