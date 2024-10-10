using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternEx
{
    public interface IPaymentFactory
    {
        IPaymentAuthorization CreateAuthorization();
    }

    // Concrete Factories
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization()
        {
            return new CreditCardAuthorization();
        }

    }

    public class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization()
        {
            return new PayPalAuthorization();
        }
    }
}
