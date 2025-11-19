using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Products;

namespace FactoryMethodPattern.Concrete.Creators;

public class CarTransportCreator : TransportCreator
{
    public override ITransport CreateTransport() => new CarTransport();
}
