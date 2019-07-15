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
        // Inventory invent;
        public int lemonsPrice;
        public int sugarPrice;
        public int icePrice;
        Recipe recip;


        //Constructor (Spawner)

        public Store()
        {
            // invent = new Inventory();
            recip = new Recipe();
            price = 0;
            profit = 0;
            loss = 0;
            lemonsPrice = 5;
            sugarPrice = 4;
            icePrice = 3;


        }

        //Member Methods (Can Do)
        public void CalculateProfit()
        {



        }

        public void GetLoss()
        {
          

        }
    }
}
