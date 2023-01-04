namespace Proxy;

public class RealSubject : Subject
{
    public override void Operation() => Console.WriteLine("RealSubject.Operation()");
}
