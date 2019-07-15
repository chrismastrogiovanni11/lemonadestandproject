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

        public bool DisplayProfit(Player player)
        {
            if (player.profit > player.budget)
            {
                Console.WriteLine("You earned a profit today");
                profit = double.Parse(Console.ReadLine());
                return true;
            }
            else if(player.loss > player.budget)
            {
                Console.WriteLine("You lost money today");
                loss = double.Parse(Console.ReadLine());
                return false;
                
            }
            else
            {
                Console.WriteLine("You broke even today");
                return false;
            }
        }



    }
}
