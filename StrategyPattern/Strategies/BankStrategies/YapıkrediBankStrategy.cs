using StrategyPattern.Abstract;
using StrategyPattern.Enums;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies.BankStrategies;

public class YapıkrediBankStrategy : IBankStrategy
{
    public void ProcessExecute(PaymentModel model)
    {
        Console.WriteLine($"{nameof(BankNameEnum.Yapıkredi)} Redirected to 3d service");
    }
}
