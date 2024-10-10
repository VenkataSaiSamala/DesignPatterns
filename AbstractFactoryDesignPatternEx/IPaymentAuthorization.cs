using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternEx
{
    public interface IPaymentAuthorization
    {
        bool AuthorizePayment(decimal amount);
    }
}
