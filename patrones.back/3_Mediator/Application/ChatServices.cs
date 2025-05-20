using patrones.back._3_Mediator.Entities;
using patrones.back._3_Mediator.Mediator;

namespace patrones.back._3_Mediator.Application
{
    public class ChatService
    {
        public void EjecutarChat()
        {
            var sala = new SalaChat();

            var juan = new Usuario("Juan");
            var maria = new Usuario("María");
            var ana = new Usuario("Ana");

            sala.Registrar(juan);
            sala.Registrar(maria);
            sala.Registrar(ana);

            juan.Enviar("Hola a todos");
            maria.Enviar("Hola Juan 👋");
            ana.Enviar("¿Cómo están?");
        }
    }
}
