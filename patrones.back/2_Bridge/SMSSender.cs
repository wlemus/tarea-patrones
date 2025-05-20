namespace Bridge;

public class SmsSender: INotificationSender
{
    private HashSet<string> _telephoneCompanies { get; } = new HashSet<string>() {"Movistar"};
    public void Send(string message)
    {
        Console.WriteLine("The message will be sent to these telephone companies: " + string.Join(", ", _telephoneCompanies.ToArray()));
        Console.WriteLine(message + " sms");
    }

    public void SetCompanies(IEnumerable<string> telephoneCompanies)
    {
        _telephoneCompanies.UnionWith(telephoneCompanies);
    }

}