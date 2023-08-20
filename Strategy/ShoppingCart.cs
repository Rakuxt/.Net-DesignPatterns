﻿namespace Strategy
{
    // Context
    internal class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Checkout(decimal totalAmount)
        {
            paymentStrategy.Pay(totalAmount);
        }
    }
}
