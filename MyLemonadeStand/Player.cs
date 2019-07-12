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
        Inventory invent;

       //Constructor (Spawner)
        public Player()
        {
            budget = 20;
            playerName = null;
            setPrice = .25;
            invent = new Inventory();

        }


        //Member Methods (Can Do)

        public void GetPlayerName()
        {
            Console.WriteLine("Enter Player name");
            playerName = Console.ReadLine();
        }
        public void PurchaseLemons()
        {
            if(true)
            {
                budget--;
            }
            else
            {

            }
            
        }

        public void PurchaseIce()
        {
            Console.WriteLine("Would you like to purchase Ice?");
            if(true)
            {
                budget--;
                
                
            }
            else
            {

                
            }
            
        }

        public void PurchaseSugar()
        {
            Console.WriteLine("Would you like to purchase sugar?");

            if ()
            {
                budget--;

            }
            else
            {

            }

        }

        public void AdjustPrice()
        {
            Console.WriteLine("Would you like to change the price?");
            price = Console.ReadLine();

        }
    }
}
