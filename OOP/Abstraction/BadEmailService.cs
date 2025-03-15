using System;


namespace OOP.abstraction;

public class BadEmailService
{
    public void SendEmail() => Console.WriteLine("Sending Email");

    public void Connect() => Console.WriteLine("Connecting");

    public void Authenticate() => Console.WriteLine("Authenticating");

    public void Disconnect() => Console.WriteLine("Disconnecting");
}