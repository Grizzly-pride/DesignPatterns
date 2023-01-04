namespace FactoryMethod;

public class ConcreteCreatorB : Creator
{
    public override Product FactoryMethod() => new ConcreteProductB();
}
