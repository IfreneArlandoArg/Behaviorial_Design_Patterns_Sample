using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    // Mediador
    public interface IChatMediator
    {
        void EnviarMensaje(string mensaje, Usuario usuario);
        void RegistrarUsuario(Usuario usuario);
    }

    // Mediador concreto
    public class ChatRoom : IChatMediator
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void RegistrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void EnviarMensaje(string mensaje, Usuario remitente)
        {
            foreach (var u in usuarios)
            {
                if (u != remitente)
                    u.Recibir(mensaje);
            }
        }
    }

    // Colegas
    public abstract class Usuario
    {
        protected IChatMediator chat;
        protected string nombre;

        public Usuario(IChatMediator chat, string nombre)
        {
            this.chat = chat;
            this.nombre = nombre;
        }

        public abstract void Enviar(string mensaje);
        public abstract void Recibir(string mensaje);
    }

    // Colegas concretos
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(IChatMediator chat, string nombre) : base(chat, nombre) { }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"{nombre} envía: {mensaje}");
            chat.EnviarMensaje(mensaje, this);
        }

        public override void Recibir(string mensaje)
        {
            Console.WriteLine($"{nombre} recibe: {mensaje}");
        }
    }

}
