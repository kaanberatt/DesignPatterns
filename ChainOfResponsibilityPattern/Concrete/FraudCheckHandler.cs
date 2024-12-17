using ChainOfResponsibilityPattern.Abstract;
using ChainOfResponsibilityPattern.Models;
using ChainOfResponsibilityPatternPattern.Concrete;
using Microsoft.Extensions.Logging;

namespace ChainOfResponsibilityPattern.Concrete;

public class FraudCheckHandler : BaseHandler
{
    private readonly ILogger<FraudCheckHandler> _logger;

    public FraudCheckHandler(ILogger<FraudCheckHandler> logger)
    {
        _logger = logger;
    }
    public override IBaseModel Handle(IBaseModel request)
    {
        var paymentModel = request as PaymentRequestModel;
        if (paymentModel == null) 
        {
            _logger.Log(LogLevel.Warning, "Payment Model is null");
            return base.NextChain(paymentModel);
        }
        if (string.IsNullOrEmpty(paymentModel.CVV)) 
        {
            // CVV boş ise fraud'a takılacak. Burada hayali bir senaryo vardır. 
            _logger.Log(LogLevel.Error, "Fraud check is detection");
            return base.NextChain(paymentModel);
        }
        _logger.Log(LogLevel.Information, "Fraud check is ok.");

        return base.NextChain(paymentModel);


    }
}
