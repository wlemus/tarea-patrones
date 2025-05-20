using Bridge;
using patrones.back._1_Builder;
using patrones.back._3_Mediator.Application;

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
            Notification webMessageNotification = new MessageNotification(new WebSender());
            webMessageNotification.Notify("Esta es una notificacion");

            var smsSender = new SmsSender();
            smsSender.SetCompanies(["Claro", "Movistar", "At&t"]);
            Notification smsAlertNotification = new AlertNotification(smsSender);
            smsAlertNotification.Notify("Esta es una notificacion");

            Notification webWarningNotification = new WarningNotification(new WebSender());
            webWarningNotification.Notify("Esta es una notificacion");

            Notification webConfirmationNotification = new ConfirmationNotification(new WebSender());
            webConfirmationNotification.Notify("Esta es una notificacion");



            //****************************************3. Mediator ****************************************

            var chat = new ChatService();
            chat.EjecutarChat();
        }
    }
}
