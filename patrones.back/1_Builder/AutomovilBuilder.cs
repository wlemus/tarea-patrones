using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._1_Builder
{
    public class AutomovilBuilder : IBuilder {
        private Automovil _auto;

        public AutomovilBuilder() {
            Reiniciar();
        }

        public void Reiniciar() {
            _auto = new Automovil();
        }

        public void SetTipoMotor(AutoTiporMotor tipoMotor) {
            _auto.TipoMotor = tipoMotor;
        }

        public void SetTransmision(AutoTransmision transmision) {
            _auto.TipoTransmision = transmision;
        }

        public void SetColor(string color) {
            _auto.Color = color;
        }

        public void SetLlantas(int cantidad) {
            _auto.Llantas = cantidad;
        }

        public void SetSistemaSonido(string sistemaSonido) {
            _auto.SistemaSonido = sistemaSonido;
        }

        public void SetInteriores(string[] interiores) {
            _auto.Interiores = interiores;
        }

        public void SetTechoSolar(bool tieneTechoSolar) {
            _auto.TechoSolar = tieneTechoSolar;
        }

        public void SetGPS(bool tieneGPS) {
            _auto.SistemaGPS = tieneGPS;
        }

        public Automovil GetAutomovil() {
            var resultado = _auto;
            Reiniciar();
            return resultado;
        }
    }

}
