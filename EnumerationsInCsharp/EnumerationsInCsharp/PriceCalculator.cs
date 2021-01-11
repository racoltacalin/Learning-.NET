using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerationsInCsharp
{
    public class PriceCalculator
    {
        /*
        public const int SmallCoffeeQuantity = 100;
        public const int NormalCoffeeQuantity = 150;
        public const int DoubleCoffeeQuantity = 300;
        */

        public double CalcPrice(CoffeeSize coffeeSize)
        {
            switch (coffeeSize)
            {
                case CoffeeSize.Small:
                    return 0.20;
                case CoffeeSize.Normal:
                    return 0.30;
                case CoffeeSize.Double:
                    return 0.60;
                default:
                    throw new InvalidOperationException("Unsupported coffee quantity: " + (int)coffeeSize);
            }
        }



        //public CashMachine()
        //{

        //}

        /*
        public double CalcPrice(int quantity)
        {
            switch (quantity)
            {
                case SmallCoffeeQuantity:
                    return 0.20;
                case NormalCoffeeQuantity:
                    return 0.30;
                case DoubleCoffeeQuantity:
                    return 0.60;
                default:
                    throw new InvalidOperationException("Unsupported coffee quantity: " + quantity);
            }
        }
        */
    }
}
