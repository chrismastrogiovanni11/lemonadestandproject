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
        public void PurchaseLemons(int lemons, int lemonPrice, Store store)
        {
            //Console.WriteLine("Would you like to purchase lemons?");
            Console.WriteLine("How many lemons would you like to purchase?");
            int lemonsToPurchase = Int32.Parse(Console.ReadLine());
            int totalLemonsPrice = lemonsToPurchase * store.lemonsPrice;

            if (lemons > 0) // if they have enough money
            {
                Console.WriteLine("You have purchased lemons! money has been taken from your budget");
                inventory.lemons += lemonsToPurchase;
                budget -= totalLemonsPrice;
            }
            else
            {
                _=inventory.lemons == lemons;
            }
            
        }

        public void PurchaseIce(int poundsofIce, int icePrice, Store store)
        {
            Console.WriteLine("Would you like to purchase Ice?");
            poundsofIce = int.Parse(Console.ReadLine());
           int totalIcePrice = poundsofIce * store.icePrice;


            if (poundsofIce > 0)
            {
                Console.WriteLine("You bought ice! You've been deducted $3");
                budget -= totalIcePrice;
                inventory.ice += poundsofIce;
                
                
            }
            else
            {
                _=inventory.ice == poundsofIce;
                
            }
            
        }

        public void PurchaseSugar(int cupsPurchased, int sugarPrice, Store store)
        {
            Console.WriteLine("Would you like to purchase sugar?");
            cupsPurchased = int.Parse(Console.ReadLine());
            int totalSugarPrice = cupsPurchased * store.sugarPrice;

            if (cupsPurchased > 0)
            {
                budget -= totalSugarPrice;
                inventory.sugar += cupsPurchased;
                Console.WriteLine("You have purchased sugar! Money has been deducted from your budget");

            }
            else
            {
                _=inventory.sugar == cupsPurchased;
            }

        }

        public void AdjustPrice()
        {

            Console.WriteLine("Would you like to change the price?");
            setPrice = double.Parse(Console.ReadLine());

        }
    }
}
