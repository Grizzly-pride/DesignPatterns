namespace Proxy;

public class Proxy : Subject
{
    public override void Operation() => new RealSubject().Operation();
}
