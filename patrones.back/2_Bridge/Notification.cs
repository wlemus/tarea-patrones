namespace Bridge;

public abstract class Notification(INotificationSender sender)
{
    protected readonly INotificationSender NotificationSender = sender;
    public abstract void Notify(string message);
}