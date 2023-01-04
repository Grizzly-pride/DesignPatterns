namespace AbstractFactory;

public class ConcreteFactoryB : AbstractFactory
{
    public override AbstractProductA CreateProductA() => new ProductA2();

    public override AbstractProductB CreateProductB() => new ProductB2();
}
