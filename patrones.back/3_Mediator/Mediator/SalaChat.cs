using patrones.back._3_Mediator.Entities;
using patrones.back._3_Mediator.Interfaces;

namespace patrones.back._3_Mediator.Mediator
{
    public class SalaChat : IMediador
    {
        private readonly List<Usuario> _usuarios = new();

        public void Registrar(Usuario usuario)
        {
            if (!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);
            usuario.SetSala(this);
        }

        public void Enviar(string mensaje, Usuario emisor)
        {
            foreach (var usuario in _usuarios)
            {
                if (usuario != emisor) { usuario.Recibir(mensaje, emisor.Nombre); }
            }
        }
    }
}
