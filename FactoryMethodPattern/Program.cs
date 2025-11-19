using System.Globalization;
using FactoryMethodPattern.Abstract;
using FactoryMethodPattern.Concrete.Creators;
using FactoryMethodPattern.Enums;

var creators = new Dictionary<TransportType, TransportCreator>
{
    { TransportType.Bicycle, new BicycleTransportCreator() },
    { TransportType.Car, new CarTransportCreator() },
    { TransportType.Ship, new ShipTransportCreator() }
};

Console.WriteLine("=== Factory Method Pattern Örneği ===");
Console.WriteLine("Şehir içi ve şehirler arası teslimatlar için uygun taşıma aracını seçin.");

var transportType = AskForTransportType();
var cargoDescription = Ask("Taşınacak yükü kısaca açıklayın:");
var distance = AskForDouble("Tahmini mesafeyi km cinsinden girin:");

var deliveryPlan = creators[transportType].PlanDelivery(cargoDescription, distance);

Console.WriteLine();
Console.WriteLine($"Seçilen araç: {deliveryPlan.TransportName}");
Console.WriteLine($"Maksimum yük kapasitesi: {deliveryPlan.MaxLoadInKg} kg");
Console.WriteLine($"Mesafe: {deliveryPlan.DistanceInKm} km");
Console.WriteLine($"Plan özeti: {deliveryPlan.Summary}");

static TransportType AskForTransportType()
{
    Console.WriteLine("1) Kurye Bisikleti\n2) Kargo Aracı\n3) Kargo Gemisi");
    Console.Write("Seçiminiz (1-3): ");

    while (true)
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out var numericChoice) && Enum.IsDefined(typeof(TransportType), numericChoice))
        {
            return (TransportType)numericChoice;
        }

        Console.Write("Geçersiz seçim. Lütfen 1-3 arasında bir değer girin: ");
    }
}

static string Ask(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return string.IsNullOrWhiteSpace(input) ? "Belirtilmemiş yük" : input.Trim();
}

static double AskForDouble(string message)
{
    Console.WriteLine(message);
    while (true)
    {
        var input = Console.ReadLine();
        if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out var value) && value > 0)
        {
            return value;
        }

        Console.Write("Lütfen sıfırdan büyük bir sayı girin: ");
    }
}
