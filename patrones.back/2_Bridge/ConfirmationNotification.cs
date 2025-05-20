namespace Bridge;

public class ConfirmationNotification(INotificationSender sender) : Notification(sender)
{
    public override void Notify(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        NotificationSender.Send("Message: " + message);
    }
}