using ChainOfResponsibilityPattern.Abstract;

namespace ChainOfResponsibilityPattern.Models;

public class PaymentRequestModel : IBaseModel
{
    public string CardNumber { get; set; }
    public string CVV { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get ; set; }
    public string CardHolderName { get; set; }
    public string DealerId { get; set; }  
    public string DealerPassword { get; set; }  
}
