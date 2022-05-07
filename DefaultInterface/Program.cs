using System;

namespace DefaultInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoppingCart shoppingCart = new BetterShoppingCart();
            shoppingCart.CalculateTotal();
            shoppingCart.CalculateSubTotal();
            
        }
    }
}
