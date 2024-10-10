namespace FactoryDesignPatternEx
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
