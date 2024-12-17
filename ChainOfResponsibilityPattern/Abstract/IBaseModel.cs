namespace ChainOfResponsibilityPattern.Abstract;

public interface IBaseModel
{
    string CardNumber { get; set; }
    decimal Amount { get; set; }
    string Currency { get; set; }
    string CardHolderName { get; set; }
}
