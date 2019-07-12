using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Player
    {

        //Member Variables (Has a)
        public int budget;
        public string playerName;
        public double setPrice;


       //Constructor (Spawner)
        public Player()
        {
            budget = 20;
            playerName = null;
            setPrice = .25;
            

        }


        //Member Methods (Can Do)

        public void GetPlayerName()
        {
            Console.WriteLine("Enter Player name");
            playerName = Console.ReadLine();
        }
        public void PurchaseLemons()
        {

            budget--;
        }

        public void PurchaseIce()
        {
            Console.WriteLine("Would you like to purchase Ice?");
            if(true)
            {
                budget--;
                Inventory.ice++;
                
            }
            else
            {
                
            }
            
        }

        public void PurchaseSugar()
        {

        }
    }
}
