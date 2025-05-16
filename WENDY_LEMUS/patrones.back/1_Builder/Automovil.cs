using patrones.back._1_Builder;

namespace patrones.back {
    public class Automovil {
        public AutoTiporMotor TipoMotor { get; set; }
        public AutoTransmision TipoTransmision { get; set; }
        public string Color { get; set; }
        public int Llantas { get; set; }
        public string SistemaSonido { get; set; }
        public string[] Interiores { get; set; }
        public bool TechoSolar { get; set; }
        public bool SistemaGPS { get; set; }

    }

}
