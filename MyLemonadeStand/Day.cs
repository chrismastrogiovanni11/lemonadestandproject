using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLemonadeStand
{
    class Day
    {

        //Member Variables (Has a)


       public Weather weather;
       public Random gnr;


        //Constructor (Spawner)

        public Day(Random rand)
        {
            gnr = rand;
            weather = new Weather(gnr);
        }

        //Member Methods (Can Do)


        
    }
}
