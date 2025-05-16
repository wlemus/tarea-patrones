using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._2_Bridge
{
    // Implementacion concreta
    public class PlataformaEscritorio : IPlataforma {
        public void EnviarMensaje(string mensaje) {
            Console.WriteLine($"[NOTIFICACIÓN DE ESCRITORIO] {mensaje}");
        }
    }
}
