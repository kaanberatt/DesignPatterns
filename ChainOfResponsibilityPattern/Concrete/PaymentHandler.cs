using ChainOfResponsibilityPattern.Abstract;
using ChainOfResponsibilityPattern.Models;
using ChainOfResponsibilityPatternPattern.Concrete;

namespace ChainOfResponsibilityPattern.Concrete;

public class PaymentHandler : BaseHandler
{
    private readonly ILogger<PaymentHandler> _logger;
    public PaymentHandler(ILogger<PaymentHandler> logger)
    {
        _logger = logger;
    }
    public override IBaseModel Handle(IBaseModel request)
    {
        var paymentModel = (PaymentRequestModel)request;

        _logger.Log(LogLevel.Information, "Payment is processing");
        _logger.Log(LogLevel.Information, "Payment is completed");

        return base.NextChain(request);
    }
}
