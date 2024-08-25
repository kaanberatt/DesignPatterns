using StrategyPattern.Enums;
using StrategyPattern.Factories;
using StrategyPattern.Models;

// Kullanıcıdan girdi alarak PaymentModel oluşturma
var paymentModel = GetPaymentModelFromUserInput();

var strategy = BankFactory.GetBank(paymentModel.BankNameEnum);
strategy.ProcessExecute(paymentModel);

static PaymentModel GetPaymentModelFromUserInput()
{
    Console.WriteLine("Lütfen bir banka seçin: 1. ZiraatBank 2. Yapıkredi 3. Vakıfbank");
    int bankChoice = int.Parse(Console.ReadLine());

    Console.WriteLine("Lütfen ödeme tutarını girin:");
    decimal amount = decimal.Parse(Console.ReadLine());

    BankNameEnum selectedBank = (BankNameEnum)bankChoice;

    return new PaymentModel
    {
        BankNameEnum = selectedBank,
        Amount = amount
    };
}