using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterface
{
    public class ShoppingCart : IShoppingCart
    {
        public void CalculateTotal()
        {
            Console.WriteLine("This is Shopping Cart CalculateTotal");
        }
    }
}
