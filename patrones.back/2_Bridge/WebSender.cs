namespace Bridge;

public class WebSender: INotificationSender
{
    public void Send(string message) => Console.WriteLine(message + " web");
}