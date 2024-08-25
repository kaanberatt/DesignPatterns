using StrategyPattern.Enums;

namespace StrategyPattern.Models
{
    public class PaymentModel
    {
        public BankNameEnum BankNameEnum { get; set; }
        public decimal Amount { get; set; }
    }
}
