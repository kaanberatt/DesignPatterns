using StrategyPattern.Abstract;
using StrategyPattern.Enums;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies.BankStrategies;

public class VakıfbankBankStrategy : IBankStrategy
{
    public void ProcessExecute(PaymentModel model)
    {
        Console.WriteLine($"{nameof(BankNameEnum.Vakıfbank)} Redirected to 3d service");
    }
}
