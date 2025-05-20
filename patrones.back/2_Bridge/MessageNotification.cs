namespace Bridge;

public class MessageNotification(INotificationSender sender) : Notification(sender)
{
    public override void Notify(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        
        SaveMesageDb(message);
        NotificationSender.Send("Message: " + message);
    }

    private void SaveMesageDb(string message)
    {
        Console.WriteLine("The message has been saved in DB.");
    }
}