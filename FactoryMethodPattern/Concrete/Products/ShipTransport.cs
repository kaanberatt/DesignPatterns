using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern.Concrete.Products;

public class ShipTransport : ITransport
{
    public string Name => "Kargo Gemisi";

    public double MaxLoadInKg => 50000;

    public string Deliver(string cargoDescription, double distanceInKm)
    {
        var duration = distanceInKm / 30; // ortalama hız 30 km/s
        return $"Gemi ile '{cargoDescription}' teslim edilecek. Tahmini süre: {duration:F1} saat.";
    }
}
