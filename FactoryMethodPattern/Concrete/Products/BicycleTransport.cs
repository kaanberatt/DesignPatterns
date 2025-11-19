using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern.Concrete.Products;

public class BicycleTransport : ITransport
{
    public string Name => "Kurye Bisikleti";

    public double MaxLoadInKg => 15;

    public string Deliver(string cargoDescription, double distanceInKm)
    {
        var duration = distanceInKm / 15; // ortalama hız 15 km/s
        return $"Bisiklet ile '{cargoDescription}' teslim edilecek. Tahmini süre: {duration:F1} saat.";
    }
}
