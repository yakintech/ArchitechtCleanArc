
using StrategyPattern.Models;

ShoppingCart cart = new ShoppingCart();

//kredi karti odemesi
cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(1000);

//paypal odemesi
cart.SetPaymentStrategy(new PayPalPayment());
cart.Checkout(1000);

//btc odemesi
cart.SetPaymentStrategy(new BitcoinPayment());
cart.Checkout(1000);

Console.ReadLine();