using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterface
{
    public interface IShoppingCart
    {
        void CalculateTotal();
        void CalculateSubTotal()
        {
            Console.WriteLine("This is default CalculateSubTotal");
        }

    }
}
