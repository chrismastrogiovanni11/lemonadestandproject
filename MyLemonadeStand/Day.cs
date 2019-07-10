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
        List<Weather> forecast = new List<Weather>("rainy", "hazy", "sunny", "hot", "cloudy");


        //Constructor (Spawner)

        public Day()
        {
            Weather weather = new Weather();
        }

        //Member Methods (Can Do)
        public void GetForecast()
        {
            for (int i = 0; i < forecast.length; i++)
            {

                
                forecast.Add(weather);

            }
            
            
           
        
        }

        public void CreateForecast()
        {

        }
        
    }
}
