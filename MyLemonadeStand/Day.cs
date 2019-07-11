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
        string [] forecast = { "rainy", "hazy", "sunny", "hot", "cloudy" };


        //Constructor (Spawner)

        public Day()
        {
            Weather weather = new Weather();
            
        }

        //Member Methods (Can Do)
        public void GetForecast()
        {
            for (int i = 0; i < forecast.Length; i++)
            {

                
               // forecast.Add();

            }
            
            
           
        
        }

        public void CreateForecast()
        {
            

        }
        
    }
}
