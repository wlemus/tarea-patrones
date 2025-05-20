using patrones.back._3_Mediator.Entities;

namespace patrones.back._3_Mediator.Interfaces
{
    public interface IMediador
    {
        void Enviar(string mensaje, Usuario emisor);
        void Registrar(Usuario usuario);
    }
}
