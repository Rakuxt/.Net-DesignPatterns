namespace Strategy
{
    // Concrete Strategies
    internal class CreditCardPayment : IPaymentStrategy
    {
        private string cardNumber;
        private string expiryDate;

        public CreditCardPayment(string cardNumber, string expiryDate)
        {
            this.cardNumber = cardNumber;
            this.expiryDate = expiryDate;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using credit card {cardNumber}");
        }
    }
}
