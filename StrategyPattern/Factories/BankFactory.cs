using StrategyPattern.Abstract;
using StrategyPattern.Enums;
using StrategyPattern.Strategies.Concrete;

namespace StrategyPattern.Factories;

public static class BankFactory
{
    public static IBankStrategy GetBank(BankNameEnum bankNameEnum)
    {
        switch (bankNameEnum)
        {
            case BankNameEnum.ZiraatBank:
                return new ZiraatBankStrategy();
            case BankNameEnum.Yapıkredi:
                return new YapıkrediBankStrategy();
            case BankNameEnum.Vakıfbank:
                return new VakıfbankBankStrategy();
            default:
                throw new NotImplementedException($"Bank is not implemented.");
        }
    }
}
