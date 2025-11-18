using ObserverPattern.Concrete.Observers;
using ObserverPattern.Concrete.Subjects;
using ObserverPattern.Models;

var stockMarket = new StockMarketSubject();

var aliInvestor = new ConsoleInvestorObserver("Ali");
var ayseInvestor = new ConsoleInvestorObserver("Ayşe");
var riskTeam = new ThresholdAlertObserver("Risk Yönetimi", 500m);

stockMarket.Attach(aliInvestor);
stockMarket.Attach(ayseInvestor);
stockMarket.Attach(riskTeam);

var updates = new List<StockPrice>
{
    new("KRDMD", 462.50m, DateTime.Now),
    new("KRDMD", 488.10m, DateTime.Now.AddMinutes(5)),
    new("KRDMD", 512.75m, DateTime.Now.AddMinutes(10))
};

foreach (var update in updates)
{
    stockMarket.UpdateState(update);
}

Console.WriteLine("\nAyşe güncellemelerden çıkıyor...\n");
stockMarket.Detach(ayseInvestor);

stockMarket.UpdateState(new StockPrice("KRDMD", 534.40m, DateTime.Now.AddMinutes(15)));

Console.WriteLine("\nYeni gözlemci (Mobil Bildirim Servisi) sisteme ekleniyor...\n");
var mobileNotifier = new ThresholdAlertObserver("Mobil Bildirim Servisi", 520m);
stockMarket.Attach(mobileNotifier);

stockMarket.UpdateState(new StockPrice("KRDMD", 545.20m, DateTime.Now.AddMinutes(20)));

Console.WriteLine("\nObserver Pattern demosu tamamlandı. Bir tuşa basarak çıkabilirsiniz...");
Console.ReadKey();
