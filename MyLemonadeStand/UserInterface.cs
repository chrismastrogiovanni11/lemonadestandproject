using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class UserInterface
    {

        //Member Variables (Has a)
        public double profit;
        public double loss;
        


        //Constructor (Spawner)
        public UserInterface()
        {

        }


        //Member Methods (Can Do)

        public void DisplayProfit(Player player)
        {
            if (player.profit > player.budget)
            {
                double.Parse(Console.ReadLine());
            }
            else if(player.loss > player.budget)
            {
                double.Parse(Console.ReadLine());
            }
           
        }



    }
}
