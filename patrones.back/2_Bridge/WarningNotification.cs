namespace Bridge;

public class WarningNotification(INotificationSender sender) : Notification(sender)
{
    public override void Notify(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        NotificationSender.Send("Warning: " + message);
    }
}