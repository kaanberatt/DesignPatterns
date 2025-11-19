using FactoryMethodPattern.Abstract;

namespace FactoryMethodPattern.Concrete.Products;

public class CarTransport : ITransport
{
    public string Name => "Kargo Aracı";

    public double MaxLoadInKg => 250;

    public string Deliver(string cargoDescription, double distanceInKm)
    {
        var duration = distanceInKm / 60; // ortalama hız 60 km/s
        return $"Araç ile '{cargoDescription}' teslim edilecek. Tahmini süre: {duration:F1} saat.";
    }
}
