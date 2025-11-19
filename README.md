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

## c) Factory Method Pattern

## Summary

The Factory Method pattern delegates object creation to subclasses, allowing the base creator to define a common workflow while concrete creators decide which product implementation to instantiate. In this repo it is demonstrated with different transportation factories (bicycle, car, ship) that plan deliveries based on distance and cargo type.

## Project Structure

- **Abstract:** `ITransport` ve `TransportCreator` arayüz/sınıfları taşıma senaryosunun sözleşmesini ve ortak planlama davranışını içerir.
- **Concrete Products:** Bisiklet, araç ve gemi gibi ulaşım seçeneklerini temsil ederek farklı hız/yük kapasitesi sağlar.
- **Concrete Creators:** Her ürün için ilgili fabrikanın nasıl oluşturulacağını tanımlar ve teslimat planını hesaplar.
- **Program.cs:** Konsol uygulaması ile kullanıcıdan alınan mesafe ve yük bilgilerine göre uygun fabrikanın seçilmesini gösteren örnek kullanım senaryosu sunar.
