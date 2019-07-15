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
        public double budget;
        public string playerName;
        public double setPrice;
        public double profit;
        public double loss;
        Inventory inventory;


       //Constructor (Spawner)
        public Player()
        {
            budget = 200;
            playerName = null;
            setPrice = .25;
            inventory = new Inventory();

        }


        //Member Methods (Can Do)

        public void GetPlayerName()
        {
            Console.WriteLine("Enter Player name");
            playerName = Console.ReadLine();
        }
        public void PurchaseLemons(int lemons, int lemonPrice)
        {
            //Console.WriteLine("Would you like to purchase lemons?");
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemonsToPurchase = Int32.Parse(Console.ReadLine());
            int totalLemonsPrice = lemonsToPurchase * lemonPrice;

            if (lemons > 0) // if they have enough money
            {
                Console.WriteLine("You have purchased lemons! money has been taken from your budget");
                inventory.lemons += lemonsToPurchase;
                budget -= totalLemonsPrice;
            }
            else
            {

            }
            
        }

        public void PurchaseIce(int poundsofIce, int icePrice)
        {
            Console.WriteLine("Would you like to purchase Ice?");
            poundsofIce = int.Parse(Console.ReadLine());
           int totalIcePrice = poundsofIce * icePrice;


            if (poundsofIce > 0)
            {
                Console.WriteLine("You bought ice! You've been deducted $3");
                budget -= totalIcePrice;
                inventory.ice += poundsofIce;
                
                
            }
            else
            {

                
            }
            
        }

        public void PurchaseSugar(int cupsPurchased, int sugarPrice)
        {
            Console.WriteLine("Would you like to purchase sugar?");
            cupsPurchased = int.Parse(Console.ReadLine());
            int totalSugarPrice = cupsPurchased * sugarPrice;

            if (cupsPurchased > 0)
            {
                budget -= totalSugarPrice;
                inventory.sugar += cupsPurchased;
                Console.WriteLine("You have purchased sugar! Money has been deducted from your budget");

            }
            else
            {

            }

        }

        public void AdjustPrice()
        {
            Console.WriteLine("Would you like to change the price?");
            setPrice = int.Parse(Console.ReadLine());

        }
    }
}
