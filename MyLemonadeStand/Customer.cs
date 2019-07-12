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
        public int money;
        public bool stop;
        public bool pay;
        public double pricePoint;
        public double willingtoSpend;


        //constructor(Spawner)
        public Customer()
        {
            money = 10;
            stop = false;
            pay = false;
            pricePoint = 0;
            willingtoSpend = .25;
            
        }

        //member methods(Can Do)





        public void customerPay(int temperature, double willingtoSpend, willingtoStop)
        {

            if (pricePoint <= willingtoSpend)
            {

                Store.budget.Add(Store);

            }
            else
            {


            }


        }



    }
}
