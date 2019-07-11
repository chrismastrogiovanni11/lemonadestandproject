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

        public void GetLemons()
        {
            Console.WriteLine("How many lemons do you want?");
            lemons = int.Parse(Console.ReadLine());
        }

        public void GetSugar()
        {
            Console.WriteLine("How much sugar do you want?");
            sugar = int.Parse(Console.ReadLine());

        }

        public void GetIce()
        {
            Console.WriteLine("How much ice do you need?");
            ice = int.Parse(Console.ReadLine());

        }
        
        
        
    }
}
