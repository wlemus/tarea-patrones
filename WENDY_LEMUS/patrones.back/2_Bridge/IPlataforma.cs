using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._2_Bridge
{
    // Interface de implementación
    public interface IPlataforma {
        void EnviarMensaje(string mensaje);
    }
}
