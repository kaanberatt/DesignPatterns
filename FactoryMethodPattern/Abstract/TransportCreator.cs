namespace FactoryMethodPattern.Abstract;

public abstract class TransportCreator
{
    public abstract ITransport CreateTransport();

    public DeliveryPlan PlanDelivery(string cargoDescription, double distanceInKm)
    {
        if (string.IsNullOrWhiteSpace(cargoDescription))
        {
            throw new ArgumentException("Yük açıklaması boş olamaz", nameof(cargoDescription));
        }

        if (distanceInKm <= 0)
        {
            throw new ArgumentException("Mesafe sıfırdan büyük olmalıdır", nameof(distanceInKm));
        }

        var transport = CreateTransport();
        var summary = transport.Deliver(cargoDescription, distanceInKm);

        return new DeliveryPlan(transport.Name, transport.MaxLoadInKg, distanceInKm, summary);
    }
}

public record DeliveryPlan(string TransportName, double MaxLoadInKg, double DistanceInKm, string Summary);
