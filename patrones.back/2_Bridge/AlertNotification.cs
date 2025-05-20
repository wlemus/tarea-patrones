namespace Bridge;

public class AlertNotification(INotificationSender sender) : Notification(sender)
{
    public override void Notify(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        NotificationSender.Send("Alert: " + message);
    }
}