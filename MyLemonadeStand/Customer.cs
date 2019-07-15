using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Customer
    {
        
        //create other customers with certain criteria in order to differeniate who stops and pays for lemonade

        //member variables (Has A)
        public bool stop;
        public bool pay;
        public double pricePoint;
        public double willingtoSpend;
        public int stopTemp;
        public double pricePaid;
        public Recipe recipe;
        


        //constructor(Spawner)
        public Customer()
        {
            stop = false;
            pay = false;
            pricePoint = 0;
            willingtoSpend = .25;
            stopTemp = 75;
            pricePaid = 0;
            
            
            
            
            
        }

        //member methods(Can Do)





        public bool CustomerStop(int temperature, Weather weather)
        {

            if (stopTemp >= weather.temperature)
            {
                Console.WriteLine("customer is interested");
                return true;

            }
            else if (stopTemp == weather.temperature)
            {
                Console.WriteLine("customer is slightly interested");
                return true;
            }
            else
            {
                Console.WriteLine("customer is not interested");
                return false;
            }
        }

        public bool customerPay(int temperature, double willingtoSpend, Player player, Weather weather, double newWillingToSpend)
        {




            if (player.setPrice <= willingtoSpend)
            {
                Console.WriteLine("customer has purchased lemonade");

                player.budget += player.setPrice;
                return true;


            }
            else if (player.setPrice >= willingtoSpend && stopTemp >= weather.temperature)
            {
                newWillingToSpend = willingtoSpend += .75;

                Console.WriteLine("customer has purchased lemonade");

                player.budget += player.setPrice;
                return true;

            }
            else
            {
                _ = player.budget == player.setPrice;
                return false;
            }

        }




    }
}
