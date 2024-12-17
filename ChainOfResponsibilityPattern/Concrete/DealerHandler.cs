using ChainOfResponsibilityPattern.Abstract;
using ChainOfResponsibilityPattern.Models;
using ChainOfResponsibilityPatternPattern.Concrete;

namespace ChainOfResponsibilityPattern.Concrete;

public class DealerHandler : BaseHandler
{
    private readonly ILogger<DealerHandler> _logger;
    public DealerHandler(ILogger<DealerHandler> logger)
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
        if (string.IsNullOrEmpty(paymentModel.DealerId) || string.IsNullOrEmpty(paymentModel.DealerPassword))
        {
            _logger.Log(LogLevel.Information, "Dealer opeartion is not completed");
            return paymentModel;
        }
        return base.NextChain(paymentModel);
    }
}
