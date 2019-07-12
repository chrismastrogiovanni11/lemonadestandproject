using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Store
    {

        //Member Variables (Has a)
        public double price;
        public int profit;
        public int loss;
        public int lemons;
        public int sugar;
        public int ice;
        Inventory invent;
        public int lemonsPrice;
        public int sugarPrice;
        public int icePrice;
        Recipe recip;


        //Constructor (Spawner)

        public Store()
        {
            invent = new Inventory();
            recip = new Recipe();
            price = 0;
            profit = 0;
            loss = 0;
            lemons = 0;
            ice = 0;
            sugar = 0;
            lemonsPrice = 5;
            sugarPrice = 8;
            icePrice = 3;

            
        }

        //Member Methods (Can Do)
        public void CalculateProfit()
        {
            


        }

        public void GetLoss()
        {



        }
        public void GetLemons()
        {
            Console.WriteLine("Would you like to purchase lemons?");
            lemons = int.Parse(Console.ReadLine());

        }

        public void GetSugar()
        {
            Console.WriteLine("Would you like to purchase sugar?");
            sugar = int.Parse(Console.ReadLine());

        }

        public void GetIce()
        {
            Console.WriteLine("Would you like to purchase ice?");
            ice = int.Parse(Console.ReadLine());

        }


    }
}
