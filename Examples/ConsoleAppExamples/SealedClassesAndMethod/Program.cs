using System;

namespace SealedClassesAndMethod
{
    public abstract class PaymentGateway
    {
        public abstract bool ProcessPayment(decimal amount);
    }
    public class RazorpayGateway : PaymentGateway
    {
        public sealed override bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing {amount:C} via Razorpay");
            return true;
        }
    }
    public sealed class SecureCardTokens
    {
        private readonly string _merchantKey;
        public SecureCardTokens(string merchantKey)
        {
            _merchantKey = merchantKey;
        }
        public string TokenzeCard(string cardNumber)
        {
            return cardNumber;
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            SecureCardTokens obj = new SecureCardTokens("SRIK12345");
        }
    }
}
