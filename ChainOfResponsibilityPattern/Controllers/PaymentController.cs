using ChainOfResponsibilityPattern.Abstract;
using ChainOfResponsibilityPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibilityPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IHandler _dealerHandler;
        private readonly IHandler _fraudCheckHandler;
        private readonly IHandler _paymentHandler;
        public PaymentController([FromKeyedServices("dealerHandler")]IHandler dealerHandler, 
            [FromKeyedServices("fraudCheckHandler")] IHandler fraudCheckHandler, 
            [FromKeyedServices("paymentHandler")] IHandler paymentHandler)
        {
            _dealerHandler = dealerHandler;
            _fraudCheckHandler = fraudCheckHandler;
            _paymentHandler = paymentHandler;
        }

        [HttpPost("ProcessPayment")]
        public IActionResult ProcessPayment([FromBody] PaymentRequestModel paymentRequest)
        {
            // chain of responsibility
            _dealerHandler.SetNext(_fraudCheckHandler).SetNext(_paymentHandler);

            var result = _dealerHandler.Handle(paymentRequest);

            return Ok(result);
        }
    }
}
