using System.Collections;

namespace Flyweight;

public class FlyweightFactory
{
    public FlyweightFactory()
    {
        Flyweights.Add("ConcreteFlyweightA", new ConcreteFlyweight());
        Flyweights.Add("ConcreteFlyweightB", new ConcreteFlyweight());
        Flyweights.Add("ConcreteFlyweightC", new ConcreteFlyweight());
    }

    private Hashtable Flyweights { get; } = new();

    public Flyweight GetFlyweight(string key) => (Flyweight)Flyweights[key];
}
