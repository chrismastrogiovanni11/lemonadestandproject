using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Recipe
    {

        //Member Variables (Has a)
        public int numberofLemons;
        public int cupsofSugar;
        public int cubesofIce;
        public int userInput;
        Inventory inventory;
        

        //Constructor (Spawner)
        public Recipe()
        {
            numberofLemons = 0;
            cupsofSugar = 0;
            cubesofIce = 0;
            userInput = 0;
            inventory = new Inventory();
           


        }



        //Member Methods (Can Do)

        public void InsertLemons()
        {
            Console.WriteLine("How many lemons would you like to put in your lemonade?");
            inventory.lemons -= int.Parse(Console.ReadLine());
        }

        public void InsertSugar()
        {
            Console.WriteLine("How much sugar would you like to put into your lemonade?");
            inventory.sugar -= int.Parse(Console.ReadLine());

        }

        public void InsertIce()
        {
            Console.WriteLine("How much ice would you like to put into your lemonade?");
            inventory.ice -= int.Parse(Console.ReadLine());
            
        }
    }
}
