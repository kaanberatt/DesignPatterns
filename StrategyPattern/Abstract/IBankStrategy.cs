using StrategyPattern.Models;

namespace StrategyPattern.Abstract;

public interface IBankStrategy
{
    void ProcessExecute(PaymentModel model);
}
