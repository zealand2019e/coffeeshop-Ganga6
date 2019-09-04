using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
   public class Cartado:Coffee
    {
        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }
        public override string ToString()
        {
            return "Cartado";
        }
    }
}
