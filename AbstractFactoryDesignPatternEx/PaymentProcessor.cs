using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternEx
{
    public class PaymentProcessor
    {
        private readonly IPaymentAuthorization _authorization;

        public PaymentProcessor(IPaymentFactory factory)
        {
            _authorization = factory.CreateAuthorization();
        }

        public bool ProcessPayment(decimal amount)
        {
            if (_authorization.AuthorizePayment(amount))
            {
                return true;
            }
            return false;
        }
    }
}
