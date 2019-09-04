using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
  public  class BlackCoffee : Coffee

    {
        public override string Strength()
        {
            return "strong";

        }
        public override int price()
        {
            return 20;
        }
        public override string ToString()
        {
            return "Black coffee";
        }
    }
}
