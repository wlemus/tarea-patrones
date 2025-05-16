using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._1_Builder
{
    public interface IBuilder
    {
        void Reiniciar();
        void SetTipoMotor(AutoTiporMotor tipoMotor);
        void SetTransmision(AutoTransmision transmision);
        void SetColor(string color);
        void SetLlantas(int cantidad);
        void SetSistemaSonido(string sistemaSonido);
        void SetInteriores(string[] interiores);
        void SetTechoSolar(bool tieneTechoSolar);
        void SetGPS(bool tieneGPS);
    }
}
