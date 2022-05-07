using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterface
{
    public class BetterShoppingCart : IShoppingCart
    {
      

        public void CalculateSubTotal()
        {
            Console.WriteLine("This is Better Shopping Cart CalculateSubTotal");
        }

        public void CalculateTotal()
        {
            Console.WriteLine("This is Better Shopping Cart CalculateTotal");

        }
    }
}
