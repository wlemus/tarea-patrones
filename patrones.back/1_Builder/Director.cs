using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrones.back._1_Builder
{
    public class Director {
        public void ConstruirAutoFamiliar(IBuilder builder) {
            builder.Reiniciar();
            builder.SetTipoMotor(AutoTiporMotor.Hibrido);
            builder.SetTransmision(AutoTransmision.Automatico);
            builder.SetColor("Azul");
            builder.SetLlantas(4);
            builder.SetSistemaSonido("Bose");
            builder.SetInteriores(new[] { "Tela", "Portavasos" });
            builder.SetTechoSolar(true);
            builder.SetGPS(true);
        }

        public void ConstruirAutoDeportivo(IBuilder builder) {
            builder.Reiniciar();
            builder.SetTipoMotor(AutoTiporMotor.Gasolina);
            builder.SetTransmision(AutoTransmision.Mecanico);
            builder.SetColor("Rojo");
            builder.SetLlantas(4);
            builder.SetSistemaSonido("Sony");
            builder.SetInteriores(new[] { "Cuero", "Asientos deportivos" });
            builder.SetTechoSolar(false);
            builder.SetGPS(false);
        }

        public void ConstruirAutoCompacto(IBuilder builder) {
            builder.Reiniciar();
            builder.SetTipoMotor(AutoTiporMotor.Electrico);
            builder.SetTransmision(AutoTransmision.Automatico);
            builder.SetColor("Blanco");
            builder.SetLlantas(4);
            builder.SetSistemaSonido("JVC");
            builder.SetInteriores(new[] { "Tela" });
            builder.SetTechoSolar(false);
            builder.SetGPS(true);
        }
    }
}
