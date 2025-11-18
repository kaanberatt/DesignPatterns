# Design Patterns
## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio or any C# IDE

### Cloning the Repository

https://github.com/kaanberatt/DesignPatterns.git

## a) Strategy Pattern

## Summary 

The Strategy design pattern allows different behaviors for a given object to be used under different circumstances. This allows for many different behaviors to be implemented and tested separately, since each will be encapsulated as an object.

## Project Structure

- **Strategy Pattern**: Implements various bank-specific payment strategies that encapsulate the logic for processing payments.
- **Factory Method Pattern**: Used within the project to create and return the appropriate bank strategy based on the user's selection.


## b) Chain Of Responsibility Pattern

## Summary 

The Chain of Responsibility design pattern lets a request go through a series of handlers. Each handler can choose to handle the request or pass it to the next handler in the series. This pattern helps keep parts of the system separate and makes it more flexible by separating the sender of the request from those who receive it.

## Project Structure

- **Keyed Services:** Keyed services are used to register and resolve different service implementations based on specific keys, providing flexibility in dependency injection.
- **Modular Handlers:** Each handler is responsible for a distinct part of the payment processing workflow, making the system easy to maintain and extend.

## c) Observer Pattern

## Summary 

Observer Pattern, belirli bir öznenin (Subject) durumundaki değişiklikleri bu özneye abone olan tüm gözlemcilere otomatik olarak iletir. Böylece gevşek bağlı, genişletilebilir ve olay odaklı mimariler kurulabilir.

## Project Structure

- **Abstract:** `ISubject<TState>` ve `IObserver<TState>` arayüzleri abonelik yönetimi ve bildirim sözleşmelerini tanımlar.
- **Concrete Subjects:** `StockMarketSubject`, gözlemci listesi yönetimi, durum güncellemesi ve seri bildirimlerden sorumludur.
- **Concrete Observers:** `ConsoleInvestorObserver` ve `ThresholdAlertObserver`, aynı bildirimi farklı şekillerde işleyen iki senaryoyu temsil eder.
- **Models:** `StockPrice` kaydı, konunun paylaştığı durum bilgisini tip güvenli hale getirir.
- **Program:** Hisse senedi fiyat güncellemeleri gönderilerek gözlemcilerin nasıl eklendiği/çıkarıldığı ve farklı zamanlarda nasıl tetiklendikleri gösterilir.

## Sample Usage

```bash
dotnet run --project ObserverPattern/ObserverPattern.csproj
```

Program çıktısında:
- Hisse fiyatı değiştikçe tüm gözlemciler otomatik bildirim alır.
- Gözlemciler çalışma zamanında eklenip çıkarılabilir.
- Farklı gözlemci türleri aynı duruma farklı aksiyonlar alarak tepki verir.
