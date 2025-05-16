using patrones.back._1_Builder;
using patrones.back._2_Bridge;

namespace patrones.test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****************************************1. Builder****************************************
            var director = new Director();
            var builder = new AutomovilBuilder();

            // Construir auto familiar
            director.ConstruirAutoFamiliar(builder);
            var autoFamiliar = builder.GetAutomovil();
            Console.WriteLine("Auto Familiar:");
            Console.WriteLine(autoFamiliar);
            Console.WriteLine();

            // Construir auto deportivo
            director.ConstruirAutoDeportivo(builder);
            var autoDeportivo = builder.GetAutomovil();
            Console.WriteLine("Auto Deportivo:");
            Console.WriteLine(autoDeportivo);
            Console.WriteLine();

            // Construir auto compacto
            director.ConstruirAutoCompacto(builder);
            var autoCompacto = builder.GetAutomovil();
            Console.WriteLine("Auto Compacto:");
            Console.WriteLine(autoCompacto);
            Console.WriteLine();

            var autoPersonalizado = builder.GetAutomovil();
            Console.WriteLine("Auto Personalizado:");
            Console.WriteLine(autoPersonalizado);


            //****************************************2. Bridge****************************************
            // Crear las plataformas
            IPlataforma plataformaWeb = new PlataformaWeb();
            IPlataforma plataformaMovil = new PlataformaMovil();
            IPlataforma plataformaEscritorio = new PlataformaEscritorio();

            // Crear notificaciones para cada plataforma
            var notificacionWeb = new Notificacion(plataformaWeb);
            var notificacionMovil = new Notificacion(plataformaMovil);
            var notificacionEscritorio = new Notificacion(plataformaEscritorio);

            // Enviar mensajes
            notificacionWeb.Mensaje("Bienvenido al portal.");
            notificacionMovil.Alerta("¡Batería baja!");
            notificacionEscritorio.Confirmacion("Actualización completada.");
            notificacionWeb.Advertencia("Estás usando una versión antigua del navegador.");
        }
    }
}
