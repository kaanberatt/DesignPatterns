using StrategyPattern.Abstract;
using StrategyPattern.Enums;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies.BankStrategies;

public class ZiraatBankStrategy : IBankStrategy
{
    public void ProcessExecute(PaymentModel model)
    {
        Console.WriteLine($"{nameof(BankNameEnum.ZiraatBank)} Redirected to 3d service");
    }
}
