using patrones.back._3_Mediator.Interfaces;

namespace patrones.back._3_Mediator.Entities
{
    public class Usuario
    {
        public string Nombre { get; }
        private IMediador _sala;

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void SetSala(IMediador sala)
        {
            _sala = sala;
        }

        public void Enviar(string mensaje)
        {
            Console.WriteLine($"\n[{Nombre} ENVÍA]: {mensaje}");
            _sala?.Enviar(mensaje, this);
        }

        public void Recibir(string mensaje, string emisor)
        {
            Console.WriteLine($"[{Nombre} RECIBE de {emisor}]: {mensaje}");
        }
    }
}
