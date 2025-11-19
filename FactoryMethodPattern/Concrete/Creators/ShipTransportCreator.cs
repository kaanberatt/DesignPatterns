using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Products;

namespace FactoryMethodPattern.Concrete.Creators;

public class ShipTransportCreator : TransportCreator
{
    public override ITransport CreateTransport() => new ShipTransport();
}
