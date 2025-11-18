namespace ObserverPattern.Models;

public record StockPrice(string Symbol, decimal Price, DateTime UpdatedAt);
