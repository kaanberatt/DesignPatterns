namespace FactoryMethodPattern.Abstract;

public interface ITransport
{
    string Name { get; }
    double MaxLoadInKg { get; }
    string Deliver(string cargoDescription, double distanceInKm);
}
