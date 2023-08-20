namespace Strategy
{
    // Concrete Strategies
    internal class PayPalPayment : IPaymentStrategy
    {
        private string email;

        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal account {email}");
        }
    }
}
