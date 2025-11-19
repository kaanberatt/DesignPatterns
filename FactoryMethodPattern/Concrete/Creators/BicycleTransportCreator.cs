using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Products;

namespace FactoryMethodPattern.Concrete.Creators;

public class BicycleTransportCreator : TransportCreator
{
    public override ITransport CreateTransport() => new BicycleTransport();
}
