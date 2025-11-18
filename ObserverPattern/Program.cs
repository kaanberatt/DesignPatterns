using ObserverPattern.Concrete;

Console.WriteLine("=== Observer Pattern Senaryoları ===");
RunStockScenario();
RunNewsScenario();

static void RunStockScenario()
{
    Console.WriteLine("\n--- Borsa Senaryosu ---");

    var acmeStock = new StockSubject("ACME", 150.25m);
    var aliInvestor = new InvestorObserver("Ali");
    var ayseInvestor = new InvestorObserver("Ayşe");

    acmeStock.Attach(aliInvestor);
    acmeStock.Attach(ayseInvestor);

    acmeStock.UpdatePrice(152.75m);
    acmeStock.UpdatePrice(147.10m);

    acmeStock.Detach(ayseInvestor);
    acmeStock.UpdatePrice(160.40m);
}

static void RunNewsScenario()
{
    Console.WriteLine("\n--- Haber Yayın Senaryosu ---");

    var publisher = new NewsPublisher("Günlük Analiz");
    var techSubscriber = new NewsSubscriber("Teknoloji Bülteni");
    var financeSubscriber = new NewsSubscriber("Finans Postası");

    publisher.Attach(techSubscriber);
    publisher.Attach(financeSubscriber);

    publisher.PublishNews("Teknoloji", "Yapay zekâ odaklı yeni çip lansmanı gerçekleştirildi.");

    publisher.Detach(financeSubscriber);
    publisher.PublishNews("Ekonomi", "Merkez Bankası faiz kararını açıkladı.");
}
