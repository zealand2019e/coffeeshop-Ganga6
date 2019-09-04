using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");
            

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
               new Latte(),
               new Cartado()
            };


            foreach (var coffeeitem in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffeeitem.price());
                Console.WriteLine("The name is:" + coffeeitem.ToString());
            }


        }
    }
}
