namespace FactoryMethod;

public class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod() => new ConcreteProductA();
}
