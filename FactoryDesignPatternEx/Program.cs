using FactoryDesignPatternEx;
using System;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Select the payment gateway (PayPal, Stripe, CreditCard): ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string gatewayName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        try
        {
#pragma warning disable CS8604 // Possible null reference argument.
            IPaymentGateway paymentGateway = PaymentGatewayFactory.CreatePaymentGateway(gatewayName);
#pragma warning restore CS8604 // Possible null reference argument.
            paymentGateway.ProcessPayment(100.00M); // Example amount
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}
