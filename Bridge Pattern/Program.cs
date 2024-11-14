using Bridge_Pattern;
using System;


public interface base_interface
{
    void Send(string message);
}

public abstract class Message
{
    protected base_interface _value;

    protected Message(base_interface value)
    {
        _value = value;
    }

    public abstract void Notify(string message);
}

public class Program
{
    public static void Main(string[] args)
    {
        base_interface email = new Email();
        base_interface sms = new SMS();

        Message textemail = new TEXTMessage(email);
        Message textsms = new HTMLMessage(sms);

        textemail.Notify("уведомление на Email.");
        textsms.Notify("HTML уведомление на SMS.");
    }
}