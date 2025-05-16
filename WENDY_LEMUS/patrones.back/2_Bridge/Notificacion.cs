using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._2_Bridge
{
    // Abstracción base
    public class Notificacion {
        protected readonly IPlataforma plataforma;

        public Notificacion(IPlataforma plataforma) {
            this.plataforma = plataforma;
        }

        public virtual void Alerta(string mensaje) {
            plataforma.EnviarMensaje($"[ALERTA] {mensaje}");
        }

        public virtual void Advertencia(string mensaje) {
            plataforma.EnviarMensaje($"[ADVERTENCIA] {mensaje}");
        }

        public virtual void Mensaje(string mensaje) {
            plataforma.EnviarMensaje($"[MENSAJE] {mensaje}");
        }

        public virtual void Confirmacion(string mensaje) {
            plataforma.EnviarMensaje($"[CONFIRMACIÓN] {mensaje}");
        }
    }
}
