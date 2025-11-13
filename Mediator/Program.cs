using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chat = new ChatRoom();
            IChatMediator chat2 = new ChatRoom();

            Usuario u1 = new UsuarioConcreto(chat, "Reagan");
            Usuario u2 = new UsuarioConcreto(chat, "Bruce");
            Usuario u3 = new UsuarioConcreto(chat, "Juana");
            Usuario u4 = new UsuarioConcreto(chat, "Mariana");
            Usuario u5 = new UsuarioConcreto(chat, "Wes");


            chat.RegistrarUsuario(u1);
            chat.RegistrarUsuario(u2);

            chat2.RegistrarUsuario(u3);
            chat2.RegistrarUsuario(u4);
            chat2.RegistrarUsuario(u5);

            //u1.Enviar("Hola, chatRoom 1!");
           // u2.Enviar("Hola, chatRoom 1!");


            u4.Enviar("Hola, chatRoom 2!");
           // u5.Enviar("Hola, chatRoom 2!");
        }
    }
}
