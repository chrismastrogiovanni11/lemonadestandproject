using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Inventory
    {

        //Member Variables (Has a)
        public int lemons;
        public int sugar;
        public int ice;

        //Constructor (Spawner)
        public Inventory()
        {
            lemons = 0;
            sugar = 0;
            ice = 0;

        }


        //Member Methods (Can Do)

        public void addLemons()
        {


        }

        public void addSugar()
        {

            // Store.sugar ++;
        }
        
        public void addIce(Player player)
        {
            
            // Store.ice ++;
        }
        
    }
}
